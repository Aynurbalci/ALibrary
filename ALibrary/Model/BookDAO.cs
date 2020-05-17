using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ALibrary.Model
{
    public class BookDAO
    {
        public int BarcodeNo { get; set; }
        public String BookTitle { get; set; }
        public String PublicationYear { get; set; }
        public String Language { get; set; }
        public String Category { get; set; }
        public String StockNumber { get; set; }
        public String NumberOfPages { get; set; }
        public String AuthorName { get; set; }




        private SqlConnection connection = new SqlConnection(Helper.ConnectionKey);
        public List<string> GetError()
        {
            List<string> errors = new List<string>();
         

            if (Helper.AynurIsStringEmpty(BookTitle))
            {
                errors.Add("BookTitle is required");
            }

            if (Helper.AynurIsStringEmpty(PublicationYear))
            {
                errors.Add("PublicationYear is required");
            }
            if (Helper.AynurIsStringEmpty(Language))
            {
                errors.Add("Language is required");
            }
            if (Helper.AynurIsStringEmpty(Category))
            {
                errors.Add("Category is required");
            }
            if (Helper.AynurIsStringEmpty(StockNumber))
            {
                errors.Add("StockNumber is required");
            }
            if (Helper.AynurIsStringEmpty(NumberOfPages))
            {
                errors.Add("NumberOfPages is required");
            }
            if (Helper.AynurIsStringEmpty(AuthorName))
            {
                errors.Add("AuthorName is required");
            }
            return errors;

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
