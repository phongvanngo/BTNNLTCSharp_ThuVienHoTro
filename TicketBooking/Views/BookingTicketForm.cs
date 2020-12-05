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

namespace TicketBooking.Views
{
    public partial class BookingTicketForm : UserControl
    {
        const int SEAT_A = 20000;
        const int SEAT_B = 30000;
        const int SEAT_C = 40000;
        private double TotalPay = 0;
        Image clientAvatar;
        public static string GenerateCode()
        {
            return Guid.NewGuid().ToString().GetHashCode().ToString("x");
        }

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
        }

        public static Image QRCodeImage(string data)
        {
            Image picQRCode;
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCode qrCode = new QRCode(qrGenerator.CreateQrCode(data,
            QRCodeGenerator.ECCLevel.Q));
            picQRCode = qrCode.GetGraphic(2, Color.Black, Color.White, false);
            qrGenerator.Dispose();
            qrCode.Dispose();
            return picQRCode;
        }

        private void button1_submit_Click(object sender, EventArgs e)
        {
            CustomerModel newCustomer = new CustomerModel();
            newCustomer.Name = textBox_Name.Text;
            newCustomer.Email = textBox_email.Text;
            newCustomer.CustomerKey = "CLIENT" + GenerateCode();

            string avatarImagePath = $@"\CustomerImageData\avatar{newCustomer.CustomerKey}.jpg";
            string qrCodeImagePath = $@"\CustomerImageData\qrcode{newCustomer.CustomerKey}.jpg";

            newCustomer.Avatar = avatarImagePath;
            newCustomer.QRCode = qrCodeImagePath;
            newCustomer.Total = TotalPay;
            newCustomer.SeatType = comboBox_SeatType.Text;
            newCustomer.DateCreated = DateTime.Now.ToString();


            Image clientQRCode = QRCodeImage(newCustomer.CustomerKey);

            clientAvatar.Save(CommonManager.ProjectDirectory() + avatarImagePath);
            clientQRCode.Save(CommonManager.ProjectDirectory() + qrCodeImagePath);

            CustomerDataProvider.SaveCustomer(newCustomer);

            SendMail(newCustomer);

        }

        public static void SendMail(CustomerModel customer)
        {
            string messageBody = $@"
                                    <div style='width:100%'>
                                        <div style='width: 80%;margin:auto'>

                                            <h1>Bạn đã đặt vé thành công!</h1>
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

            MessageBox.Show("Gửi Mail xác nhận thành công");


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

        private void comboBox_SeatType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_SeatType.Text)
            {
                case "A":
                    TotalPay = SEAT_A;
                    break;
                case "B":
                    TotalPay = SEAT_B;
                    break;
                case "C":
                    TotalPay = SEAT_C;
                    break;
                default:
                    break;
            }
            label_Total.Text = FormatMoney(TotalPay);
        }
    }
}
