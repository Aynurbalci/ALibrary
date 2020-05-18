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
        public static SqlConnection connection = new SqlConnection("server=(localdb)\\mssqllocaldb;Database=User;Integrated security=true");
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
        private void textBox_Password_Enter_1(object sender, EventArgs e)
        {
            if (textBox_Password.Text == "Password")
            {
                textBox_Password.Text = "";
                textBox_Password.ForeColor = Color.Black;
                textBox_Password.PasswordChar = '*';

            }
        }
        char? none = null;
        private void textBox_Password_Leave_1(object sender, EventArgs e)
        {
            if (textBox_Password.Text == "")
            {
                textBox_Password.Text = "Password";
                textBox_Password.PasswordChar = Convert.ToChar(none);
            }
            textBox_Password.ForeColor = Color.Silver;
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

        private void button_Login_Click_1(object sender, EventArgs e)
        {
            UserDAO userDAO = new UserDAO();
            string UserName = textBox_UserName.Text.Trim();
            string Password = textBox_Password.Text.Trim();
            LibraryUser userExist = userDAO.GetUser(UserName, Password);

            if (userExist != null)
            {
                LibraryBook librarySystem = new LibraryBook();
                Helper.LogginUser = userExist;
                librarySystem.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User does not exist");
            }
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

