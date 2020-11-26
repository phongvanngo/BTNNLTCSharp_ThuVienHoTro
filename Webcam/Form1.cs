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

namespace Webcam
{
    public partial class Form1 : Form
    {
        private Capture cap;
        Timer myTimer = new Timer();
        public Form1()
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
            pictureBox_whiteAndBlack.Image = grayFrame.ToBitmap();
            pictureBox_color.Image = nextFrame.ToBitmap();
            
        }
    }
}
