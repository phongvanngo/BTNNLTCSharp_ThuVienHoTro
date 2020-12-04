using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBooking.Models
{
    class CustomerModel
    {
        public string CustomerKey { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string QRCode { get; set; }
        public string SeatType { get; set; }
        public string DateCreated { get; set; }
        public string Email { get; set; }
        public double Total { get; set; }
    }
}
