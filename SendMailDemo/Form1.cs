using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;
using Imgur.API.Authentication;
using System.Net.Http;
using Imgur.API.Endpoints;
using Imgur.API.Models;
using System.Net.Mime;

namespace SendMailDemo
{
    public partial class Form1 : Form
    {


        MailMessage message;
        SmtpClient smtp;
        public Form1()
        {
            InitializeComponent();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            //message.CC.Add(textBox1_cc.Text);
            //message.CC.Add(textBox2_content.Text);
            //message.Subject = "huiiii";

            //message.From = new MailAddress("deepak.sharma009@gmail.com");

            Email(textBox2_content.Text);


        }

        public static void PostToImgur(string imagFilePath, string imgurApiKey)
        {

        }

        public static void Email(string htmlString)
        {
            //try
            //{
            //    MailMessage message = new MailMessage();
            //    SmtpClient smtp = new SmtpClient();
            //    message.From = new MailAddress("phongngonovapo@gmail.com");
            //    message.To.Add(new MailAddress("novapohht@gmail.com"));
            //    message.Subject = "Test";
            //    message.IsBodyHtml = true; //to make message body as html  
            //    message.Body = htmlString;
            //    smtp.Port = 587;
            //    smtp.Host = "smtp.gmail.com"; //for gmail host  
            //    smtp.EnableSsl = true;
            //    smtp.Credentials = new NetworkCredential("phongngonovapo@gmail.com", "Novapotrucmei2412gmail");
            //    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            //    smtp.UseDefaultCredentials = true;
            //    smtp.Send(message);
            //    MessageBox.Show("success");
            //}
            //catch (Exception) {
            //    throw;
            //}

            string messageBody = @"
 <div style='width:100%'>
        <div style='width: 50%;margin:auto'>

            <h2>Bạn đã đặt vé thành công!</h2>
            <p>Xin Chào <b>Ngô Văn Phóng,</b> </h1>
            <p><b>Xin Chào Vé của bạn đã được đính kèm trong email này</b>, Xin vui lòng in vé và mang tới sự kiện hoặc
                mở trên smart phone khi soát vé. </h1>
            </p>            
            <p>Mã QRCode của bạn được đính kèm trong file bên dưới </h1>
            </p>
        </div>
    </div>
";
            System.Drawing.Image im = System.Drawing.Image.FromFile(@"");

            var CurrentDirectory = System.Environment.CurrentDirectory;
            string CurrentProjectD = Directory.GetParent(CurrentDirectory).Parent.FullName;

            string attachmentPath = CurrentProjectD + @"\Resources\websiteQRCode_noFrame.png";
            Attachment inline = new Attachment(attachmentPath);
            inline.ContentDisposition.Inline = true;
            inline.ContentDisposition.DispositionType = DispositionTypeNames.Inline;
            inline.ContentId = "Fdf";
            inline.ContentType.MediaType = "image/png";
            inline.ContentType.Name = Path.GetFileName(attachmentPath);


            GuiMail("novapohht@gmail.com", "phongngonovapo@gmail.com", "hhaha", messageBody,inline);

        }

        public static void GuiMail(string from, string to, string subject, string body, Attachment file = null)
        {

            MailMessage mess = new MailMessage(from, to,subject,body);
            mess.IsBodyHtml = true;



            mess.Attachments.Add(file);




            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(from, "ngovanphong");





            client.Send(mess);

        }
    }
}

