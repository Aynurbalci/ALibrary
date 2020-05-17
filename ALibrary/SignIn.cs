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
        private void textBox_UserName_Enter(object sender, EventArgs e)
        {

            if (textBox_UserName.Text == "me@gmail.com or User Name")
            {
                textBox_UserName.Text = "";
            }
            textBox_UserName.ForeColor = Color.Black;
        }

        private void textBox_UserName_Leave(object sender, EventArgs e)
        {
            if (textBox_UserName.Text == "")
            {
                textBox_UserName.Text = "me@gmail.com or User Name";
            }
            textBox_UserName.ForeColor = Color.Silver;
        }
        private void textBox_UserName_MouseEnter(object sender, EventArgs e)
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
        private void textBox_Password_Enter(object sender, EventArgs e)
        {
            if (textBox_Password.Text == "Password")
            {
                textBox_Password.Text = "";
                textBox_Password.ForeColor = Color.Black;
                textBox_Password.PasswordChar = '*';

            }


        }
        char? none = null;
        private void textBox_Password_Leave(object sender, EventArgs e)
        {

            if (textBox_Password.Text == "")
            {
                textBox_Password.Text = "Password";
                textBox_Password.PasswordChar = Convert.ToChar(none);
            }
            textBox_Password.ForeColor = Color.Silver;
        }
        #endregion
        //botton_Login properties
        #region
        private void button_Login_MouseHover(object sender, EventArgs e)
        {
            button_Login.BackColor = Color.Blue;
        }

        private void button_Login_MouseLeave(object sender, EventArgs e)
        {
            button_Login.BackColor = Color.DarkRed;
        }

        #endregion

        private void button_Login_Click(object sender, EventArgs e)
        {
            UserDAO userDAO = new UserDAO();
            string UserName = textBox_UserName.Text.Trim();
            string Password = textBox_Password.Text.Trim();
            bool userExist = userDAO.IsUserExist(UserName, Password);       

            if (userExist)
            {
                LibraryBook librarySystem = new LibraryBook();
                librarySystem.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User does not exist");
            }

        }      

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            
        }

    
    }
}
