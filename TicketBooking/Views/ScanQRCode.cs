using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using ZXing;
using TicketBooking.Models;
using TicketBooking.Database;


namespace TicketBooking.Views
{
    public partial class ScanQRCode : UserControl
    {
        private Capture cap;
        Timer myTimer = new Timer();
        Image QRCodeImage;

        bool scanMode = false;
        public ScanQRCode()
        {
            InitializeComponent();

            myTimer.Interval = 50;
            myTimer.Tick += MyTimer_Tick;

            labelLoaiGhe.Text = "Loại chỗ ngồi";
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            if (cap == null) return;

            Image<Bgr, byte> nextFrame = cap.QueryFrame();
            Image<Gray, byte> grayFrame = nextFrame.Convert<Gray, byte>();

            nextFrame = nextFrame.Flip(FLIP.HORIZONTAL);
            QRCodeImage = nextFrame.ToBitmap();
            pictureBox1_scanQRCode.Image = QRCodeImage;
            //myTimer.Stop();
            GetDataFromQRCode(QRCodeImage);
        }

        public void GetDataFromQRCode(Image MyQRCode)
        {
            Bitmap imgQRCode = (Bitmap)MyQRCode;
            if (imgQRCode != null)
            {
                ZXing.BarcodeReader Reader = new ZXing.BarcodeReader();
                Result result = Reader.Decode(imgQRCode);
                if (result != null)
                {
                    string decoded = result.ToString().Trim();
                    CustomerModel customer = CustomerDataProvider.GetCustomer(decoded);

                    if (customer != null)
                    {
                        cap.Dispose();
                        myTimer.Stop();
                        label_email.Text = customer.Email;
                        label_dateCreated.Text = customer.DateCreated;
                        label_SeatType.Text = customer.SeatType;
                        label1_name.Text = customer.Name;
                        ovalPictureBox1_avatar.Image = Image.FromFile(CommonManager.ProjectDirectory() + customer.Avatar);

                        SuccessCheckInForm resultForm = new SuccessCheckInForm(customer);

                        
                        resultForm.ShowDialog();
                        while (resultForm.IsClose == false) { };
                        cap = new Capture(0);
                        myTimer.Start();

                    }
                }

            }
        }

        private void button1_scan_Click(object sender, EventArgs e)
        {
            if (scanMode == true)
            {
                scanMode = false;
                myTimer.Stop();
                cap.Dispose();
                button1_scan.Text = "Quét";
            }
            else
            {
                scanMode = true;
                myTimer.Start();
                cap = new Capture(0);
                button1_scan.Text = "Dừng";

            }
        }
    }
}
