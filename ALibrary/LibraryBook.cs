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

namespace ALibrary
{
    public partial class LibraryBook : Form
    {
        public LibraryBook()
        {
            InitializeComponent();
        }

        private void LibraryBook_Load(object sender, EventArgs e)
        {
            FillAllBook();
        }
        private void FillAllBook()
        {
            BookDAO bookDAO = new BookDAO();
            dataGridView_GettingBooks.DataSource = bookDAO.GetAllBook();
            dataGridView_BooksInTheLibrary.DataSource = bookDAO.GetAllBook();
        }


        #region
        bool move;
        int mouse_x;
        int mouse_y;



        private void LibraryBook_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void LibraryBook_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void LibraryBook_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void button_All_Click(object sender, EventArgs e)
        {
            BookIn();
        }
        private void BookIn()
        {
            BookInsert();
            FillAllBook();
        }
        private void BookInsert()
        {

            try
            {

                BookDAO bookDAO = new BookDAO();
                bookDAO.BookTitle = textBox_BookTitle.Text;
                bookDAO.AuthorName = textBox_AuthorName.Text;
                bookDAO.PublicationYear = textBox_PublicationYear.Text;
                bookDAO.Language = comboBox_Language.Text;
                bookDAO.Category = comboBox_Category.Text;
                bookDAO.StockNumber = textBox_Piece.Text;
                bookDAO.NumberOfPages = textBox_NumberOfPages.Text;

                List<String> errors = bookDAO.GetError();
                if (!errors.Any())
                {
                    bookDAO.Insert();
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
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void dataGridView_BooksInTheLibrary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridView_BooksInTheLibrary.Rows[rowIndex];
                textBox_BookTitle.Text = row.Cells["BookTitle"].ToString();
                textBox_AuthorName.Text = row.Cells["AuthorName"].ToString();
                textBox_PublicationYear.Text = row.Cells["PublicationYear"].ToString();
                comboBox_Language.Text = row.Cells["Language"].ToString();
                comboBox_Category.Text = row.Cells["Category"].ToString();
                textBox_Piece.Text = (row.Cells["StockNumber"].ToString());
                textBox_NumberOfPages.Text = row.Cells["NumberOfPages"].ToString();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (tabControl1.SelectedIndex == 1) 
            {
                UserDAO userDAO = new UserDAO();
                dataGridView_MyBooks.DataSource = userDAO.GetAllUserBooks(Helper.LogginUser);
            }          
        }


    }
}
