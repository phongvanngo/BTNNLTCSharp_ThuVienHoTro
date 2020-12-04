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
            panel_scanQrCode.Controls.Add(scanQRCodeArea);
            panel_FormBookingArea.Controls.Add(bookingForm);
        }
    }
}
