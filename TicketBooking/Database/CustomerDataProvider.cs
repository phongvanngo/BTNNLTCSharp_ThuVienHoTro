using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBooking.Models;

namespace TicketBooking.Database
{
    class CustomerDataProvider
    {
        public static string LoadConnectionString()
        {
            //lấy database ko phải trong thư mục debug
            var CurrentDirectory = System.Environment.CurrentDirectory;
            string CurrentProjectD = Directory.GetParent(CurrentDirectory).Parent.FullName;
            return (@"Data Source=" + CurrentProjectD + @"\Database\CustomerDetailDatabase.db");
        }

        public static List<CustomerModel> LoadCustomers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<CustomerModel>("select * from Drink", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveCustomer(CustomerModel Customer)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Customer (CustomerKey,Name,Avatar,QRCode,SeatType,Total,DateCreated) " +
                    "values(@CustomerKey,@Name,@Avatar,@QRCode,@SeatType,@Total,@DateCreated)"
                    , Customer);
            }
        }
    }
}
