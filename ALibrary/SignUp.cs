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
using System.Runtime.InteropServices.WindowsRuntime;
using System.Drawing.Text;
using System.Reflection;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
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
            UserDAO userSignUpDAO = new UserDAO();
            dataGridView_SignUp.DataSource = userSignUpDAO.GetAllUserSignUp();
        }

        //Finalexamproperties
        private void FinalExamProperties()
        {
            #region
            //buton>>property(enable,visible,text)
            button_SignUp.Enabled = false;
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
            checkedListBox_BookTypes.SelectedValue = 1;
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
            label_UserName.Text = "First Name";
            label_UserName.Enabled = true;
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
            notifyIcon1.BalloonTipText = "Sign Up!";
            notifyIcon1.BalloonTipTitle = "Sign";
            notifyIcon1.Icon = SystemIcons.Application;
            //numericUpDown>>property(value)
            numericUpDown_BookNumber.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            //PictureBox>>property(SizeMode,image)
            pictureBox_Picturee.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Picturee.Image = Properties.Resources.Books_2_icon;
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
            textBox_FirstName.ContextMenuStrip = contextMenuStrip1;
            textBox_FirstName.Multiline = true;
            textBox_FirstName.Font = new Font("Verdana", 7.875F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(162)));
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
            menuStrip1.Text = "Alibrary";
            menuStrip1.Items.AddRange(new ToolStripItem[] {aToolStripMenuItem});
            aToolStripMenuItem.Text = "Alibrary";
            aToolStripMenuItem.DropDown = contextMenuStrip1;
            //errorProvider>>property(icon)
            errorProvider1.SetError(textBox_Gmail, "mandatory field");//iconu özellikler kısmından ekledim
           //Timer>>property(interval)
            timer1.Interval = 100;

            //DataGridView>>property(multiSelect,SelectionMode,BorderStyle,GridColor,DataSource)
              dataGridView_SignUp.MultiSelect = false;
              dataGridView_SignUp.GridColor = Color.DarkRed;
            dataGridView_SignUp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
              dataGridView_SignUp.BorderStyle = BorderStyle.Fixed3D;
            dataGridView_SignUp.DataSource = "(localdb)\\mssqllocaldb";





            #endregion
            //FinalExamProperties
        }
        //FinalExamEvents
        #region
        //buton>>event(EnableChanged,VisibleChanged,Click,MouseHover)
        #region
        private void button_SignUp_EnabledChanged(object sender, EventArgs e)
        {
            button_SignUp.Enabled = true; //Enable özelliğinin değiştirilmesi durumunda bu parametre çalışır.
           
        }
        private void button_SignUp_VisibleChanged(object sender, EventArgs e)
        {
            button_SignUp.BackColor=Color.Red;//Visible özelliği değiştirilince çalışır.
        }
        private void button_SignUp_Click(object sender, EventArgs e)
        {
            SignUpSignIn(); //button_SignUp_Click e basınca gerçekleşmesini istediğimiz olayları yazmamızı sağlar.

        }
        private void button_SignUp_MouseHover(object sender, EventArgs e)
        {
            button_SignUp.BackColor = Color.Cornsilk;//Mause butonun üzerine gelince çalışır.
        }
        #endregion
        //CheckBox>>event(CheckedChanged)
        #region
        private void checkBox_Married_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_Married.BackColor = Color.Red; //checked değerinin özelliği değiştiğinde kullanılır.
        }

        private void checkBox_Single_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_Single.BackColor = Color.Cyan;//checked değerinin özelliği değiştiğinde kullanılır.
        }
        #endregion
        //CheckedListBox>>events(itemcheck, selectedvaluechanged)
        #region
        private void checkedListBox_BookTypes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            checkedListBox_BookTypes.BackColor = Color.Yellow;//checkedlistboxda Bir öğenin seçili olması durumunda gerçekleşir. 
        }
        private void checkedListBox_BookTypes_SelectedValueChanged(object sender, EventArgs e)
        {
                checkedListBox_BookTypes.BackColor = Color.White;//SelectedValue özelliği değiştiğinde gerçekleşir.

        }
        #endregion
        //Combobox>>events(selectedindexchanged, mousedoubleclick)
        #region
        private void comboBox_EducationStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_EducationStatus.BackColor = Color.Azure;
        }
        private void comboBox_EducationStatus_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            comboBox_EducationStatus.BackColor = Color.DarkRed;
        }
        #endregion
        //DatetimePicker>>events(ValueChanged)
        #region
        private void dateTimePicker_DateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            button_SignUp.BackColor = Color.Yellow;//Tarih değeri değiştiği zaman etkinleşir.

        }
        #endregion
        //Label>>events(VisibleChanged)
        #region
         private void label_UserName_VisibleChanged(object sender, EventArgs e)
        {
            textBox_FirstName.BackColor = Color.DarkKhaki;//Labelin visible özelliği değiştinde etkinleşir.
        }
        #endregion
        //Listbox>>events(SelectIndexChanged,BackColorChanged,SelectedValueChanged)
        #region
        private void listBox_AddressType_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_AddressType.BackColor = Color.DarkOliveGreen;//Seçilen index değişince etkinleşir.
        }

        private void listBox_AddressType_SelectedValueChanged(object sender, EventArgs e)
        {
            button2.BackColor = Color.Yellow;//seçilen değer değişince etkinleşir.
        }
        private void listBox_AddressType_BackColorChanged(object sender, EventArgs e)
        {
            button_SignUp.BackColor = Color.DarkTurquoise;//Arka plan renginin değişmesi halinde aktifleşir.
        }
        #endregion
        //Listview>>events(itemChecked,SelectIndexChanged)
        #region
        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            pictureBox2.Visible = false;//list viewe tıklama yapma durumunda aktifleşir yani öğe seçilmesi gerekir.
            pictureBox_Picture.Visible = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            ;//seçilen öğenin değişmesi durumunda çalışır.
        }

        #endregion
        //MaskedTextBox>>events(TypeValidationCompleted)
        #region
        private void maskedTextBox_PhoneNumber_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            maskedTextBox_PhoneNumber.BackColor = Color.AliceBlue;// ValidatingType özelliğini kullanarak geçerli değeri ayrıştırmayı tamamladığında oluşur.
        }
        #endregion
        //notifylIcon>>events(BalloonTipClicked,BalloonTipClosed,BalloonTipShown)
        #region
        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            textBox_UserName.BackColor = Color.Red;//balon ipucu tıklanınca etkin olur
        }

        private void notifyIcon1_BalloonTipClosed(object sender, EventArgs e)
        {
            textBox_Address.BackColor = Color.Crimson;//balon ipucu kapatılınca etkin olur

        }

        private void notifyIcon1_BalloonTipShown(object sender, EventArgs e)
        {
            maskedTextBox_PhoneNumber.BackColor = Color.LightSeaGreen;//balon ipucu ekran da görününce etkinleşir

        }
        private void button2_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "Sign Up!";
            notifyIcon1.BalloonTipTitle = "Sign";
            notifyIcon1.ShowBalloonTip(1000);
        }
        #endregion
        //numericUpDown>>events(ValueChanged)
        #region
        private void numericUpDown_BookNumber_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_BookNumber.BackColor = Color.DeepSkyBlue; //numericdeki sayı değeri değişince aktifleşir
        }
        #endregion
        //PictureBox>>events(click)
        #region
        private void pictureBox_Picturee_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();  //pictureboxa basınca aktifleşir.
            signUp.BackColor = Color.Red;
        }
        #endregion
        //ProgressBar>>events(click)
        #region
        private void progressBar_Fill_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registration Hand");//progressbara tıklanması halinde aktif olur
        }
        #endregion
        //Radiobutton>>events(checkedchanged)
        #region
        private void radioButton_Man_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_Women.BackColor = Color.Cyan;//radio butonun değimesi durumunda etkin olur
        }

        private void radioButton_Women_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_Man.BackColor = Color.DarkMagenta;//radio butonun değimesi durumunda etkin olur
        }
        #endregion
        //Textbox>>events(TextXhanged,MouseUp)
        #region
        private void textBox_FirstName_TextChanged(object sender, EventArgs e)
        {
            textBox_FirstName.BackColor = Color.Aqua;//textbox içine değer yazınca aktifleşir.
        }

        private void textBox_FirstName_MouseUp(object sender, MouseEventArgs e)
        {
            textBox_FirstName.BackColor = Color.Coral;//textbox a mouse tıklaması ile gerçekleşir.
        }
        #endregion
        //TabControl>>events(click)
        #region
        private void tabControl1_Click(object sender, EventArgs e)
        {
            maskedTextBox_IdentificationNumber.BackColor = Color.Red;//tab kontrole tıklanması halinde aktifleşir.
        }
        #endregion
        //Timer>>events(Tick)
        #region
        private void timer1_Tick(object sender, EventArgs e)
        {
            aToolStripMenuItem.Text = DateTime.Now.ToString();
        }
        #endregion
        #endregion

        private void SignUpSignIn()
        {
            SignUpInsert();
            FillAllUserSigns();
        }

        //İnsert
        #region
        private void SignUpInsert()
        {

            try
            {

                UserDAO userSignUpDAO = new UserDAO();
                userSignUpDAO.UserName = textBox_UserName.Text;
                userSignUpDAO.Password = textBox_Password.Text;
                userSignUpDAO.Gender = "Women";

                if (radioButton_Man.Checked)
                {
                    userSignUpDAO.Gender = "Man";
                }
                if (radioButton_Women.Checked)
                {
                    userSignUpDAO.Gender = "Women";
                }

                userSignUpDAO.DateOfBirth =GetDate();
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
                //DATA ACCESS OBJECT
                userSignUpDAO.BookType = checkedListBox_BookTypes.Text;
                userSignUpDAO.IdentificationNumber = maskedTextBox_IdentificationNumber.Text;
                userSignUpDAO.Address = textBox_Address.Text;
                userSignUpDAO.AddressType = GetAdressType();
                userSignUpDAO.Gmail = textBox_Gmail.Text;
                userSignUpDAO.MobilePhone = (maskedTextBox_PhoneNumber.Text);
                userSignUpDAO.FirstName = textBox_FirstName.Text;
                userSignUpDAO.LastName = textBox_LastName.Text;
                userSignUpDAO.Picture = textBox_PictureUrl.Text;

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

        private string GetAdressType()
        {
            try
            {
                return listBox_AddressType.SelectedItem.ToString();
            }
            catch (Exception)
            {

                return "";
            }
        }
       static UserDAO userDAO = new UserDAO();

        private DateTime GetDate()
        {
            try
            {
                return dateTimePicker_DateOfBirth.Value;            }
            catch (Exception)
            {

                return DateTime.Now;
            }
        }
        #endregion
        string Gender;
        private void dataGridView_SignUp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridView_SignUp.Rows[rowIndex];
                textBox_FirstName.Text = row.Cells["UserName"].ToString();
                textBox_Password.Text = row.Cells["Password"].ToString();

                dateTimePicker_DateOfBirth.Value = Convert.ToDateTime(row.Cells["DateOfBirth"].ToString());
                comboBox_EducationStatus.Text = row.Cells["EducationStatus"].ToString();

                checkedListBox_BookTypes.Text = row.Cells["BookType"].ToString();
                maskedTextBox_IdentificationNumber.Text = row.Cells["IdentificationNumber"].ToString();
                textBox_FirstName.Text= (row.Cells["FirstName"].ToString());
                textBox_Address.Text = row.Cells["Address"].ToString();
                listBox_AddressType.Text = row.Cells["AddressType"].ToString();
                textBox_LastName.Text = row.Cells["LastName"].ToString();
                textBox_Gmail.Text = row.Cells["Gmail"].ToString();
                maskedTextBox_PhoneNumber.Text = row.Cells["MobilePhone"].ToString();
                textBox_PictureUrl.Text = row.Cells["Picture"].ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
          
        }

        private void button_PictureSelect_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox_Picturee.ImageLocation = openFileDialog1.FileName;
            textBox_PictureUrl.Text = openFileDialog1.FileName;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView_SignUp.CurrentRow.Cells[0].Value);
                userDAO.Delete(id);
                MessageBox.Show("Deleted!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }          
        }

        private void button6_Click(object sender, EventArgs e)
        {

            // userDAO.Id = Convert.ToInt32(dataGridView_SignUp.CurrentRow.Cells[0].Value);

            FillAllUserSigns();
        }
    }
}
