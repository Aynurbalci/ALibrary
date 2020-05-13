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
using System.Globalization;
using ALibrary.Model;

namespace ALibrary
{
    public partial class SignUp : Form
    {

        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            FinalExamProperties();
            FillAllUserSigns();

        }

        private void FillAllUserSigns()
        {
            UserSignUpDAO userSignUpDAO = new UserSignUpDAO();
            dataGridView_SignUp.DataSource = userSignUpDAO.GetAllUserSignUp();
        }


        private void FinalExamProperties()
        {
            #region
            //buton>>property(enable,visible,text)
            button_SignUp.Enabled = true;
            button_SignUp.Visible = true;
            button_SignUp.Text = "Sign Up";
            //CheckBox>>property(checked,text)
            checkBox_Married.Checked = false;
            checkBox_Single.Checked = false;
            checkBox_Married.Text = "Married";
            checkBox_Single.Text = "Single";
            //CheckedListBox>>Property(sorted,selectionmode)
            checkedListBox_BookTypes.Sorted = false;
            checkedListBox_BookTypes.SelectionMode = SelectionMode.One;
            //Combobox>>property(sorted,dropdownstyle,flatstyle,items)
            comboBox_EducationStatus.Sorted = false;
            comboBox_EducationStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_EducationStatus.FlatStyle = FlatStyle.Flat;
            comboBox_EducationStatus.Items.AddRange(new object[] {
            "Associate degree ",
            "Bachelor\'s ",
            "Graduat eschool/Master\'s",
            "High school",
            "Primary school",
            "Secondary/Elementary school ",
            "Vocational school "});
            //DateTimePicker>>property(maxdate,mindate,showupdown)
            dateTimePicker_DateOfBirth.MaxDate = new DateTime(9966, 12, 26, 0, 0, 0, 0);
            dateTimePicker_DateOfBirth.MinDate = new DateTime(1900, 12, 26, 0, 0, 0, 0);
            dateTimePicker_DateOfBirth.ShowUpDown = false;
            //Label>>property(visible,text)
            label_UserName.Visible = true;
            label_UserName.Text = "User Name";
            //Listbox>>property(SelectionMode,Sorted,Backcolor)
            listBox_AddressType.SelectionMode = SelectionMode.One;
            listBox_AddressType.Sorted = false;
            listBox_AddressType.BackColor = SystemColors.Info;
            //Listview(HeaderStyle,MultiSelect,Sorting,BorderStyle,CheckBoxes,FullRowSelect,GridLines,View)
            listView1.HeaderStyle = ColumnHeaderStyle.Clickable;
            listView1.MultiSelect = true;
            listView1.Sorting = System.Windows.Forms.SortOrder.None;
            listView1.BorderStyle = BorderStyle.Fixed3D;
            listView1.CheckBoxes = true;
            listView1.FullRowSelect = false;
            listView1.GridLines = false;
            listView1.View = View.Details;
            //MaskedTextBox>>property(Mask,PasswordChar,TextMaskFormat)
            maskedTextBox_IdentificationNumber.Mask = "00000000000";
            maskedTextBox_IdentificationNumber.PasswordChar = '*';
            maskedTextBox_IdentificationNumber.TextMaskFormat = MaskFormat.IncludePrompt;
            //Notifylcon>>property(BalloonTiplcon,BalloonTipText,BalloonTipTitleilcon?)
            notifyIcon1.BalloonTipIcon = ToolTipIcon.None;
            notifyIcon1.BalloonTipText = null;
            notifyIcon1.BalloonTipTitle = null;
            //numericUpDown>>property(value)
            numericUpDown_BookNumber.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            //PictureBox>>property(SizeMode,image)
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Properties.Resources.Books_2_icon;
            //ProgressBar>>property(value,step,maximum,minimum)
            progressBar_Fill.Value = 1;
            progressBar_Fill.Step = 10;
            progressBar_Fill.Maximum = 100;
            progressBar_Fill.Minimum = 0;
            //Radiobutton>>property(checked,text)
            radioButton_Women.Text = "Women";
            radioButton_Man.Text = "Man";
            radioButton_Women.Checked = false;
            radioButton_Man.Checked = false;
            //Textbox>>(contextmenustrip,multiline,font)
            textBox_UserNames.ContextMenuStrip = contextMenuStrip1;
            textBox_UserNames.Multiline = true;
            textBox_UserNames.Font = new Font("Verdana", 7.875F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(162)));
            //ToolTip>>property(IsBaloon,ToolTiplcon,ToolTipTitle)
            toolTip1.IsBalloon = false;
            toolTip1.ToolTipIcon = ToolTipIcon.Warning;
            toolTip1.ToolTipTitle = null;
            //TabControl>>property(TabPages>>Text)
            tabPage_UserRegistration.Text = "User Registration";
            tabPage_UserRegControl.Text = "User Registration Control";
            //Groupbox>>property(text)
            groupBox_Gender.Text = "Gender";
            //MenuStrip>>property(items>>toolStripMenuItem>>property(text,dropdownıtems>>property(text)))

            //errorProvider>>property(icon)

            //Timer>>property(interval)
            //DataGridView>>property(multiSelect,)







            #endregion
            //FinalExamProperties
        }


        private void CallConnection()
        {

        }
        private void SignUpSignIn()
        {
            SignUpInsert();
            FillAllUserSigns();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUpSignIn();
        }

        private void SignUpInsert()
        {

            try
            {

                UserSignUpDAO userSignUpDAO = new UserSignUpDAO();
                userSignUpDAO.UserNames = textBox_UserNames.Text;
                userSignUpDAO.UserSurname = textBox_UserSurname.Text;
                userSignUpDAO.Gender = "Women";

                if (radioButton_Man.Checked)
                {
                    userSignUpDAO.Gender = "Man";
                }
                if (radioButton_Women.Checked)
                {
                    userSignUpDAO.Gender = "Women";
                }

                userSignUpDAO.DateOfBirth = dateTimePicker_DateOfBirth.Value;
                userSignUpDAO.EducationStatus = comboBox_EducationStatus.Text;
                userSignUpDAO.MaritalStatus = "Single";
                if (checkBox_Married.Checked)
                {
                    userSignUpDAO.MaritalStatus = "Married";
                }
                if (checkBox_Single.Checked)
                {
                    userSignUpDAO.MaritalStatus = "Single";
                }
                userSignUpDAO.BookTypes = checkedListBox_BookTypes.Text;
                userSignUpDAO.IdentificationNumber = maskedTextBox_IdentificationNumber.Text;
                userSignUpDAO.HowManyBooks = (int)numericUpDown_BookNumber.Value;
                userSignUpDAO.Address = textBox_Address.Text;
                userSignUpDAO.AddressType = listBox_AddressType.SelectedItem.ToString();
                userSignUpDAO.LoginUsername = textBox_LoginUserName.Text;
                userSignUpDAO.Gmails = textBox_Gmail.Text;
                userSignUpDAO.PhoneNumber = (maskedTextBox_PhoneNumber.Text);


                List<String> errors = userSignUpDAO.GetErrors();
                if (!errors.Any())
                {
                    userSignUpDAO.Insert();
                }
                else
                {
                    MessageBox.Show(string.Join(",", errors));

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }







        private void button2_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
        }
        string Gender;
        private void dataGridView_SignUp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridView_SignUp.Rows[rowIndex];
                textBox_UserNames.Text = row.Cells["UserNames"].ToString();
                textBox_UserSurname.Text = row.Cells["UserSurname"].ToString();

                dateTimePicker_DateOfBirth.Value = Convert.ToDateTime(row.Cells["DateOfBirth"].ToString());
                comboBox_EducationStatus.Text = row.Cells["EducationStatus"].ToString();

                checkedListBox_BookTypes.Text = row.Cells["BookTypes"].ToString();
                maskedTextBox_IdentificationNumber.Text = row.Cells["IdentificationNumber"].ToString();
                numericUpDown_BookNumber.Value = int.Parse(row.Cells["HowManyBooks"].ToString());
                textBox_Address.Text = row.Cells["Address"].ToString();
                listBox_AddressType.Text = row.Cells["AddressType"].ToString();
                textBox_LoginUserName.Text = row.Cells["LoginUsername"].ToString();
                textBox_Gmail.Text = row.Cells["Gmail"].ToString();
                maskedTextBox_PhoneNumber.Text = row.Cells["PhoneNumber"].ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }




    }
}
