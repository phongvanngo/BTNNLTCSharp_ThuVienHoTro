using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
                var output = cnn.Query<CustomerModel>("select * from Customer", new DynamicParameters());
                return output.ToList();
            }
        }        
        public static CustomerModel GetCustomer(string code)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sqlcommand = $@"select * from Customer where CustomerKey = '{code}' ";
                var output = cnn.Query<CustomerModel>(sqlcommand, new DynamicParameters());
                CustomerModel custome = output.ToList()[0];
                if (output != null) return output.ToList()[0]; 
                else return null;
            }
        }
        public static void SaveCustomer(CustomerModel Customer)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Customer (Email,CustomerKey,Name,Avatar,QRCode,SeatType,Total,DateCreated) " +
                    "values(@Email,@CustomerKey,@Name,@Avatar,@QRCode,@SeatType,@Total,@DateCreated)"
                    , Customer);
            }
        }
    }
}
