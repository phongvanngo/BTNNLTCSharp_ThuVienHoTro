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
using System.IO;
using TicketBooking.Properties;

using QRCoder;

namespace TicketBooking
{
    public partial class Demo : Form
    {
        private Capture cap;
        Timer myTimer = new Timer();
        Image QRCodeImage;
        public Demo()
        {
            InitializeComponent();
            cap = new Capture(0);
            myTimer.Interval = 100;
            myTimer.Tick += MyTimer_Tick;
            myTimer.Start();

        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            Image<Bgr, byte> nextFrame = cap.QueryFrame();
            Image<Gray, byte> grayFrame = nextFrame.Convert<Gray, byte>();

            nextFrame = nextFrame.Flip(FLIP.HORIZONTAL);
            QRCodeImage = nextFrame.ToBitmap();
            pictureBox1.Image = QRCodeImage;
            //myTimer.Stop();
            GetDataFromQRCode(QRCodeImage);




            //GetDataFromQRCode(Image.FromFile(@"C:\Users\19520\source\repos\BTNNLTCSharp_ThuVienHoTro\TicketBooking\CustomerImageData\qrcodeCLIENT8361e7b0.jpg"));

            //var CurrentDirectory = System.Environment.CurrentDirectory;
            //string CurrentProjectD = Directory.GetParent(CurrentDirectory).Parent.FullName;
            //string mypath = CurrentProjectD + @"\CodeImage";
            //QRCodeImage.Save(mypath+ @"\code1.png");

            //myTimer.Stop();
            //pictureBox1.Image = Image.FromFile(mypath+ @"\code1.png");
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
                    textBox1.Text = decoded;
                }

            }
        }
        static string base64String = null;

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\19520\Downloads\websiteQRCode_noFrame.png";
            //Image myimage = (Image)Resources.Save;
            pictureBox1.Image = Resources.Save;
            System.Drawing.Image image = System.Drawing.Image.FromFile(path);

            MemoryStream m = new MemoryStream();

            image.Save(m, image.RawFormat);
            byte[] imageBytes = m.ToArray();
            base64String = Convert.ToBase64String(imageBytes);
            MessageBox.Show(base64String);



            richTextBox1.Text = base64String;

        }
    }
}
