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

namespace TicketBooking.Views
{

    public partial class TakePictureForm : Form
    {
        private Capture cap;
        Timer myTimer = new Timer();
        Image myPicture;

        public Image MyPicture { get => myPicture; set => myPicture = value; }

        public TakePictureForm()
        {
            InitializeComponent();
            cap = new Capture(0);
            myTimer.Interval = 100;

            myTimer.Tick += MyTimer_Tick;
            button1_OK.Enabled = false;
            button1_takeAgain.Enabled = false;
            myTimer.Start();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            
            Image<Bgr, byte> nextFrame = cap.QueryFrame();

            nextFrame = nextFrame.Flip(FLIP.HORIZONTAL);
            pictureBox1_camera.Image = nextFrame.ToBitmap();
            //GetDataFromQRCode(QRCodeImage);

        }

        private void button1_takepicture_Click(object sender, EventArgs e)
        {
            myTimer.Stop();
            cap.Dispose();

            button1_OK.Enabled = true;
            button1_takeAgain.Enabled = true;
        }

        private void button1_takeAgain_Click(object sender, EventArgs e)
        {
            cap = new Capture(0);
            button1_OK.Enabled = false;
            button1_takeAgain.Enabled = false;
            myTimer.Start();
        }

        private void button1_OK_Click(object sender, EventArgs e)
        {
            myPicture = pictureBox1_camera.Image;
            cap.Dispose();
            Close();
        }
    }
}
