using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketBooking.Models;
using System.Globalization;
using QRCoder;
using TicketBooking.Database;
using System.Net.Mail;
using System.Net.Mime;
using System.IO;
using System.Net;
using System.Threading;

namespace TicketBooking.Views
{
    public delegate void SendmailHandler(MailAddress mail);
    public delegate void myDelegate();
    public partial class BookingTicketForm : UserControl
    {
        const int SEAT_A = 150000;
        const int SEAT_B = 200000;
        const int SEAT_C = 350000;
        private double TotalPay = 0;
        string EventJoin = "";
        Image clientAvatar;
        Thread ThreadLoading;

        private double TamTinh = 0;

        public static string GenerateCode()
        {
            return Guid.NewGuid().ToString().GetHashCode().ToString("x");
        }

        public event myDelegate notify;

        public static string FormatMoney(double total)
        {
            CultureInfo elGR = CultureInfo.CreateSpecificCulture("el-GR");
            return String.Format(elGR, "{0:0,0}", (total)) + " VND";
        }
        public BookingTicketForm()
        {


            InitializeComponent();
            comboBox_SeatType.SelectedIndex = 0;
            TotalPay = SEAT_A;
            label_Total.Text = FormatMoney(TotalPay);

            ThreadLoading = new Thread(ShowLoadingPage);
        }

        public void ShowLoadingPage()
        {
            Loading loadingPage = new Loading();
            loadingPage.ShowDialog();
        }




        public static Image QRCodeImage(string data)
        {
            Image picQRCode;
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCode qrCode = new QRCode(qrGenerator.CreateQrCode(data,
            QRCodeGenerator.ECCLevel.Q));
            picQRCode = qrCode.GetGraphic(8, Color.Black, Color.White, false);
            qrGenerator.Dispose();
            qrCode.Dispose();
            return picQRCode;
        }

        private void button1_submit_Click(object sender, EventArgs e)
        {

            //check valid data
            if (clientAvatar == null || textBox_Name.Text == "" || textBox_email.Text == "")
            {
                MessageBox.Show("Dữ liệu đầu vào không hợp lệ");
                return;
            }
            
            ThreadLoading = new Thread(ShowLoadingPage);
            ThreadLoading.Start();

            CustomerModel newCustomer = new CustomerModel();
            newCustomer.Name = textBox_Name.Text;
            newCustomer.Email = textBox_email.Text;
            newCustomer.CustomerKey = "CLIENT" + GenerateCode();

            string avatarImagePath = $@"\CustomerImageData\avatar{newCustomer.CustomerKey}.jpg";
            string qrCodeImagePath = $@"\CustomerImageData\qrcode{newCustomer.CustomerKey}.jpg";

            newCustomer.Avatar = avatarImagePath;
            newCustomer.QRCode = qrCodeImagePath;
            newCustomer.Total = TotalPay;
            newCustomer.ThoiGianSuKien = comboBox3_TimeAndPlace.Text;
            newCustomer.SeatType = comboBox_SeatType.Text;
            newCustomer.SuKienThamDu = EventJoin;
            newCustomer.DateCreated = DateTime.Now.ToString();


            Image clientQRCode = QRCodeImage(newCustomer.CustomerKey);

            clientAvatar.Save(CommonManager.ProjectDirectory() + avatarImagePath);

            CustomerDataProvider.SaveCustomer(newCustomer);
            Image clientQRCodee = QRCodeImage(newCustomer.CustomerKey);
            Bitmap b = new Bitmap(400, 400);
            Graphics g = Graphics.FromImage(b);
            g.Clear(Color.White);
            g.DrawImage(clientQRCode, 100, 100, 200, 200);
            clientQRCode = (Image)b;

            clientQRCode.Save(CommonManager.ProjectDirectory() + qrCodeImagePath);
            try
            {
                SendMail(newCustomer);
                MessageBox.Show("Gửi Mail xác nhận thành công");
                textBox_email.Text = "";
                textBox_Name.Text = "";
                ovalPictureBox1_avatar.Image = null;
                clientAvatar = null;
                comboBox_SeatType.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Gửi không thành công");
            }

        }

        public void SendMail(CustomerModel customer)
        {
            string messageBody = $@"
                                    <div style='width:100%'>
                                        <div style='width: 100%;margin:auto'>

                                            <h1>Bạn đã đặt vé tham dự VIET NAM WEB SUMMIT thành công!</h1>
                                            <p>Xin Chào <b>{customer.Name}</b>, cám ơn bạn đã đặt vé tham gia sự kiện</h1>
                                            </p>
                                            <h2>Thông tin vé của bạn</h2>
                                            <table style='width:100%;border: 1px solid black;'>

                                                <tr>
                                                    <th align='left' scope='row'>Tên </td>
                                                    <td>{customer.Name}</td>
                                                </tr>   

                                                <tr>
                                                    <th align='left' scope='row'>Ngày giờ đặt vé </td>
                                                    <td>{customer.DateCreated}</td>
                                                </tr>  

                                                <tr>
                                                    <td>{customer.DateCreated}</td>
                                                    <td align='left' scope='row'> <b>Thông tin sự kiện</b></td>
                                                </tr>  

                                                <tr>
                                                    <th align='left' scope='row'>Địa điểm và thời gian </td>
                                                    <td>{customer.ThoiGianSuKien}</td>
                                                </tr>

   

                                                <tr>
                                                    <th align='left' scope='row'>Sự kiện tham gia </td>
                                                    <td>
 {customer.SuKienThamDu}   
</td>
                                                </tr>

                                                                                
                                                <tr>
                                                    <th align='left' scope='row'>Loại chỗ ngồi </td>
                                                    <td>{customer.SeatType}</td>
                                                </tr>
                                                <tr>
                                                    <th align='left' scope='row'>Tổng cộng </td>
                                                    <td>{customer.Total}</td>
                                                </tr>



                                            </table>
                                            <p>Mã QRCode của bạn được đính kèm trong file bên dưới </h1>
                                            </p>
                                        </div>
                                    </div>
                                ";

            string attachmentPath = CommonManager.ProjectDirectory() + customer.QRCode;
            Attachment QrCodeAttachment = new Attachment(attachmentPath);
            QrCodeAttachment.ContentDisposition.Inline = true;
            QrCodeAttachment.ContentDisposition.DispositionType = DispositionTypeNames.Inline;
            QrCodeAttachment.ContentId = "Fdf";
            QrCodeAttachment.ContentType.MediaType = "image/jpg";
            QrCodeAttachment.ContentType.Name = Path.GetFileName(attachmentPath);

            MailMessage mess = new MailMessage("novapohht@gmail.com", customer.Email, "XÁC NHẬN ĐÃ MUA VÉ", messageBody);

            mess.IsBodyHtml = true;
            mess.Attachments.Add(QrCodeAttachment);
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("novapohht@gmail.com", "ngovanphong");

            client.Send(mess);

            ThreadLoading.Abort();

            notify();


        }

        private void button_takePicture_Click(object sender, EventArgs e)
        {
            TakePictureForm myCamera = new TakePictureForm();
            if (DialogResult.OK == myCamera.ShowDialog())
            {
                clientAvatar = myCamera.MyPicture;
                ovalPictureBox1_avatar.Image = clientAvatar;
            }
            else
            {

            }
        }

        public void TinhTien()
        {
            EventJoin = "";
            TotalPay = TamTinh;
            if (checkBox2.Checked)
            {
                TotalPay += 100000;
                string dau = "<p>";
                EventJoin += checkBox2.Text;
                string cuoi = "</p>";
                EventJoin = dau + EventJoin + cuoi;
            }
            if (checkBox3.Checked)
            {
                TotalPay += 100000;
                string dau = "<p>";
                EventJoin += checkBox3.Text;
                string cuoi = "</p>";
                EventJoin = dau + EventJoin + cuoi;
            }
            if (checkBox4.Checked)
            {
                TotalPay += 100000;

                string dau = "<p>";
                EventJoin += checkBox4.Text;
                string cuoi = "</p>";
                EventJoin = dau + EventJoin + cuoi;
            }
            if (checkBox5.Checked)
            {
                TotalPay += 100000;
                string dau = "<p>";
                EventJoin += checkBox5.Text;
                string cuoi = "</p>";
                EventJoin = dau + EventJoin + cuoi;
            }
            if (checkBox1.Checked)
            {
                TotalPay += 100000;
                string dau = "<p>";
                EventJoin += checkBox1.Text;
                string cuoi = "</p>";
                EventJoin = dau + EventJoin + cuoi;
            }

            label_Total.Text = FormatMoney(TotalPay);
        }

        private void comboBox_SeatType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_SeatType.Text)
            {
                case "Hạng A":
                    TamTinh = SEAT_A;
                    break;
                case "Hạng B":
                    TamTinh = SEAT_B;
                    break;
                case "Hạng C":
                    TamTinh = SEAT_C;
                    break;
                default:
                    break;
            }
            TinhTien();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            TinhTien();
        }
    }
}
