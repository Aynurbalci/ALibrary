using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ALibrary.Model;

namespace ALibrary
{
    public partial class SignIn : Form
    {
        public static SqlConnection connection = new SqlConnection("server=(localdb)\\mssqllocaldb;Database=AynurLibraryDb;Integrated security=true");
        public SignIn()
        {
            InitializeComponent();
        }
        //textbox_username properties
        #region
        private void textBox_UserName_Enter_1(object sender, EventArgs e)
        {
            if (textBox_UserName.Text == "me@gmail.com or User Name")
            {
                textBox_UserName.Text = "";
            }
            textBox_UserName.ForeColor = Color.Black;
        }
        private void textBox_UserName_Leave_1(object sender, EventArgs e)
        {
            if (textBox_UserName.Text == "")
            {
                textBox_UserName.Text = "me@gmail.com or User Name";
            }
            textBox_UserName.ForeColor = Color.Silver;
        }
        private void textBox_UserName_MouseEnter_1(object sender, EventArgs e)
        {
            textBox_UserName.BackColor = Color.YellowGreen;
        }
        private void textBox_UserName_MouseLeave(object sender, EventArgs e)
        {
            textBox_UserName.BackColor = Color.White;
        }
        #endregion
        //textbox_Password properties
        #region
        private void timer1_Tick(object sender, EventArgs e)
        {
            textbox_Password.Text = textBox2.Text;
        }
        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.Show();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.Hide();
        }

        char? none = null;
       

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textbox_Password.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.PasswordChar = '*';

            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textbox_Password.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.PasswordChar = Convert.ToChar(none);
            }
            textBox2.ForeColor = Color.Silver;
        }

        #endregion
        //button_Login properties
        #region
        private void button_Login_MouseHover_1(object sender, EventArgs e)
        {
            button_Login.BackColor = Color.Blue;
        }

        private void button_Login_MouseLeave_1(object sender, EventArgs e)
        {
            button_Login.BackColor = Color.DarkRed;
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
        public void GetUser(string username, string password)
        {
            OpenConnection();
            string cmd = "SELECT * FROM LibraryUser WHERE (UserName = @UserName OR Gmail = @Gmail) AND Password = @Password";
            SqlCommand command = new SqlCommand(cmd, connection);
            command.Parameters.AddWithValue("@UserName", username);
            command.Parameters.AddWithValue("@Gmail", username);
            command.Parameters.AddWithValue("@Password", password);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            CloseConnection();

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("User does not exist");
                return;
            }

            LibraryBook librarySystem = new LibraryBook();
            librarySystem.UserId = dt.Rows[0]["Id"].ToString();
            librarySystem.UserPicture = dt.Rows[0]["Picture"].ToString();
            librarySystem.UserName = dt.Rows[0]["UserName"].ToString();
            librarySystem.Show();
            this.Hide();

        }
        private void button_Login_Click_1(object sender, EventArgs e)
        {
            string UserName = textBox_UserName.Text.Trim();
            string Password = textbox_Password.Text.Trim();
            GetUser(UserName, Password);


        }

        #endregion
        //Label
        #region
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordLearn passwordLearn = new PasswordLearn();
            passwordLearn.Show();
            this.Hide();
        }

        private void linkLabel_Home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }




        #endregion

     
       
    }
}

