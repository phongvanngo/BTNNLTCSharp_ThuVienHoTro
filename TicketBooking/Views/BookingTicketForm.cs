﻿using System;
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
            Image picQRCode ;
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

            string avatarImagePath = $@"\CustomerImageData\avatar{newCustomer.CustomerKey}.png";
            string qrCodeImagePath = $@"\CustomerImageData\qrcode{newCustomer.CustomerKey}.png";

            Image clientQRCode = QRCodeImage(newCustomer.CustomerKey);

            clientAvatar.Save(CommonManager.ProjectDirectory()+ avatarImagePath);
            clientQRCode.Save(CommonManager.ProjectDirectory() + qrCodeImagePath);
            
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
