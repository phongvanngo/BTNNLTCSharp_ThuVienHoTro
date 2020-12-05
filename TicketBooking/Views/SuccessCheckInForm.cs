using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TicketBooking.Models;

namespace TicketBooking.Views
{
    public partial class SuccessCheckInForm : Form
    {
        CustomerModel customer;
        Timer myTimer = new Timer();
        int time_out = 1;
        bool isClose = false;
        public SuccessCheckInForm(CustomerModel customer)
        {
            InitializeComponent();
            this.customer = customer;
            myTimer.Interval = 1000;
            myTimer.Tick += MyTimer_Tick;
            label_email.Text = customer.Email;
            label_dateCreated.Text = customer.DateCreated;
            label_SeatType.Text = customer.SeatType;
            label1_name.Text = customer.Name;
            ovalPictureBox1_avatar.Image = Image.FromFile(CommonManager.ProjectDirectory() + customer.Avatar);

            myTimer.Start();

        }

        public bool IsClose { get => isClose; set => isClose = value; }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            if (time_out == 0)
            {
                IsClose = true;
                this.Close();
            }
            else
            {
                time_out--;
            }
        }

        private void SuccessCheckInForm_Load(object sender, EventArgs e)
        {


        }
    }
}
