using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketBooking.Views;

namespace TicketBooking
{
    public partial class MainWindow : Form
    {
        BookingTicketForm bookingForm = new BookingTicketForm();
        ScanQRCode scanQRCodeArea = new ScanQRCode();
        public MainWindow()
        {
            InitializeComponent();
            bookingForm.Dock = DockStyle.Fill;
            scanQRCodeArea.Dock = DockStyle.Fill;

            bookingForm.notify += BookingForm_notify;
            panel_scanQrCode.Controls.Add(scanQRCodeArea);
            panel_FormBookingArea.Controls.Add(bookingForm);
        }

        private void BookingForm_notify()
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
