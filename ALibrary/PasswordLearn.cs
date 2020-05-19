using ALibrary.Model;
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


namespace ALibrary
{
  
    public partial class PasswordLearn : Form
    {
        public static string emaill = "";
        public static string passwordd = "";
        public static string username = "";
        public PasswordLearn()
        {
            InitializeComponent();
        }
     
        private void SendEmail(string address, string subject, string message)
        {

            string email = "alibrary.com@gmail.com";
            string password = "91827364aynur";
            var loginInfo = new NetworkCredential(email, password);
            var msg = new MailMessage();
            var smtpClient = new SmtpClient("smtp.gmail.com", 587);

            msg.From = new MailAddress(email);
            msg.To.Add(new MailAddress(address));
            msg.Subject = subject;
            msg.Body = message;
            msg.IsBodyHtml = true;

            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = loginInfo;
            smtpClient.Send(msg);
        }
        private void message()
        {
            SendEmail("", "Password", "Welcome to Aynur's library Your password is "+passwordd);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
