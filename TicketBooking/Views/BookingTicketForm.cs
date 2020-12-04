using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketBooking.Views
{
    public partial class BookingTicketForm : UserControl
    {
        public BookingTicketForm()
        {
            InitializeComponent();
            comboBox_SeatType.SelectedIndex = 0;
        }

        private void button1_submit_Click(object sender, EventArgs e)
        {

        }

        private void button_takePicture_Click(object sender, EventArgs e)
        {
            TakePictureForm myCamera = new TakePictureForm();
            if (DialogResult.OK == myCamera.ShowDialog())
            {
                ovalPictureBox1_avatar.Image = myCamera.MyPicture;
            } 
            else
            {

            }
        }
    }
}
