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
using System.Data.SqlClient;


namespace ALibrary
{

    public partial class PasswordLearn : Form
    {
        public static string emaill = "";
        public static string passwordd = "";
        public static string username = "";
        private object password;
        public static readonly string ConnectionKey = "server=(localdb)\\mssqllocaldb;Database=AynurLibraryDb;Integrated security = true";

        private SqlConnection connection = new SqlConnection(ConnectionKey);

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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenConnection();
            username = textBox1.Text;
            string cmd = "SELECT * FROM LibraryUser WHERE (UserName = @UserName OR Gmail = @Gmail)";
            SqlCommand command = new SqlCommand(cmd, connection);
            command.Parameters.AddWithValue("@UserName", username);
            command.Parameters.AddWithValue("@Gmail", username);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Böyle bir kullanıcı yok "+(username??""));
                return;
            }
            String Gmail = dt.Rows[0]["Gmail"].ToString();
            string UserName = dt.Rows[0]["UserName"].ToString();
            string Password = dt.Rows[0]["Password"].ToString();
            SendEmail(Gmail, "Password", "Welcome to Aynur's library Your password is"+Password);
            CloseConnection();
        }
        private void CloseConnection()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        private void OpenConnection()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }
    }
}
