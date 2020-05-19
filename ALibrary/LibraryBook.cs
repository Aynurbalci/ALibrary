using ALibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALibrary
{
    public partial class LibraryBook : Form
    {  public string UserId { get; set; }
        public int BarcodeNo { get; set; }
        public String BookTitle { get; set; }
        public String PublicationYear { get; set; }
        public String Language { get; set; }
        public String Category { get; set; }
        public String StockNumber { get; set; }
        public String NumberOfPages { get; set; }
        public String AuthorName { get; set; }
        public string UserPicture { get; internal set; }
        public string UserName { get; internal set; }

        public List<string> GetError()
        {
            List<string> errors = new List<string>();


            if (AynurIsStringEmpty(BookTitle))
            {
                errors.Add("BookTitle is required");
            }

            if (AynurIsStringEmpty(PublicationYear))
            {
                errors.Add("PublicationYear is required");
            }
            if (AynurIsStringEmpty(Language))
            {
                errors.Add("Language is required");
            }
            if (AynurIsStringEmpty(Category))
            {
                errors.Add("Category is required");
            }
            if (AynurIsStringEmpty(StockNumber))
            {
                errors.Add("StockNumber is required");
            }
            if (AynurIsStringEmpty(NumberOfPages))
            {
                errors.Add("NumberOfPages is required");
            }
            if (AynurIsStringEmpty(AuthorName))
            {
                errors.Add("AuthorName is required");
            }
            return errors;

        }
        public void Insert()
        {
            OpenConnection();
            string cmd = @"INSERT INTO [dbo].[Book]
           (
             [BookTitle]
           ,[PublicationYear]
           ,[Language]
           ,[Category]
           ,[StockNumber]
           ,[NumberOfPages]
           ,[AuthorName])
             VALUES
           (
           @BookTitle
           ,@PublicationYear
           ,@Language
           ,@Category
           ,@StockNumber
           ,@NumberOfPages
            ,@AuthorName)";



            SqlCommand command = new SqlCommand(cmd, connection);
            command.Parameters.Add(new SqlParameter("@BookTitle", BookTitle));
            command.Parameters.Add(new SqlParameter("@PublicationYear", PublicationYear));
            command.Parameters.Add(new SqlParameter("@Language", Language));
            command.Parameters.Add(new SqlParameter("@Category", Category));
            command.Parameters.Add(new SqlParameter("@StockNumber", StockNumber));
            command.Parameters.Add(new SqlParameter("@NumberOfPages", NumberOfPages));
            command.Parameters.Add(new SqlParameter("@AuthorName", AuthorName));



            command.ExecuteNonQuery();

            CloseConnection();
        }


        public static readonly string ConnectionKey = "server=(localdb)\\mssqllocaldb;Database=AynurLibraryDb;Integrated security = true";
        static SqlConnection connection = new SqlConnection(ConnectionKey);

        public static bool AynurIsStringEmpty(string a)
        {
            return a == null || a.Trim().Length == 0;
        }

      


        public void CloseConnection()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public void OpenConnection()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {


            OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM Book WHERE BookTitle LIKE '%" + textBox_BookTitlee.Text + "%'", connection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();

            sqlDataAdapter.Fill(dataSet);
            dataGridView_GettingBooks.DataSource = dataSet.Tables[0];
            CloseConnection();
            search();
            search2();
            search3();

        }
        #region
        private void search()
        {

            OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM Book WHERE Language LIKE '%" + comboBox_Languagee.Text + "%'", connection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();

            sqlDataAdapter.Fill(dataSet);
            dataGridView_GettingBooks.DataSource = dataSet.Tables[0];
            CloseConnection();

        }
        private void search2()
        {

           OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM Book WHERE Category LIKE '%" + comboBox_Categoryy.Text + "%'", connection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView_GettingBooks.DataSource = dataSet.Tables[0];
            CloseConnection();

        }
        private void search3()
        {

            OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM Book WHERE AuthorName LIKE '%" + textBox_AuthorNamee.Text + "%'", connection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView_GettingBooks.DataSource = dataSet.Tables[0];
            CloseConnection();

        }
        #endregion
        public DataTable GetBook(string bookIdStr)
        {
            try
            {
                int bookId = Convert.ToInt32(bookIdStr);
                OpenConnection();
                string key = "SELECT * FROM Book WHERE BarcodeNo=@bookId";
                SqlCommand command = new SqlCommand(key, connection);
                command.Parameters.AddWithValue("bookId", bookId);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                CloseConnection();
                return dt;
            }
            catch (Exception ex)
            {

                return null;
            }

        }
        public DataTable GetAllBook()
        {
            OpenConnection();
            string key = "SELECT * FROM Book";
            SqlCommand command = new SqlCommand(key, connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CloseConnection();
            return dt;
        }


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
            dataGridView_BooksInTheLibrary.DataSource =GetAllBook();
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
            Insert();
            FillAllBook();
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

        public DataTable GetAllUserBooks()
        {
            OpenConnection();
            string key = "SELECT * FROM UserBook WHERE UserId=@UserId";
            SqlCommand command = new SqlCommand(key, connection);
            command.Parameters.AddWithValue("UserId",UserId);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataTable dataTable = null;
            foreach (DataRow row in dt.Rows)
            {
                DataTable temp = GetBook(row["BookId"].ToString());

                if (temp == null)
                {
                    continue;
                }

                if (dataTable == null)
                {
                    dataTable = temp;
                    continue;
                }

                dataTable.Merge(temp);

            }

            CloseConnection();
            return dataTable;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (tabControl1.SelectedIndex == 1) 
            {
                
                dataGridView_MyBooks.DataSource =GetAllUserBooks();
            }          
        }







      
        public static DateTime AynurDateTimeParser(string dateString)
        {
            try
            {
                CultureInfo provider = CultureInfo.InvariantCulture;
                DateTime dateTime = DateTime.ParseExact(dateString, new string[] { "dd.MM.yyyy", "dd-MM-yyyy", "dd/MM/yyyy" }, provider, DateTimeStyles.None);
                return dateTime;
            }
            catch (Exception ex)
            {
                return DateTime.Now;
            }
        }



    }
}
