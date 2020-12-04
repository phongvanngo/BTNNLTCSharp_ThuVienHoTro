using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBooking
{
    public static class CommonManager
    {
        public static string ProjectDirectory()
        {
            //lấy database ko phải trong thư mục debug
            var CurrentDirectory = System.Environment.CurrentDirectory;
            string CurrentProjectD = Directory.GetParent(CurrentDirectory).Parent.FullName;
            return CurrentProjectD;
        }
    }
}
