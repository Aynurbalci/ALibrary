using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALibrary.Model
{
    public class UserLibraryDAO
    {
        private SqlConnection connection = new SqlConnection(Helper.ConnectionKey);
        public String UserName { get; set; }
        public String Password { get; set; }
        public String Gmail { get; set; }
        public List<string> GetErrors()
        {
            List<string> errors = new List<string>();

            if (Helper.AynurIsStringEmpty(UserName))
            {
                errors.Add("UserName is required");
            }

            if (Helper.AynurIsStringEmpty(Password))
            {
                errors.Add("Password is required");
            }

            if (Helper.AynurIsStringEmpty(Gmail))
            {
                errors.Add("Gmail is required");
            }

            return errors;
       
        }
        public DataTable GetAllUserLibrary()
        {
            OpenConnection();
            string key = "SELECT * from UserLibrary";
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

            string cmd = "INSERT INTO UserSignUp VALUES(@UserName,@Gmail,@Password)";

            SqlCommand command = new SqlCommand(cmd, connection);
            command.Parameters.Add(new SqlParameter("@UserName", UserName));
            command.Parameters.Add(new SqlParameter("@Gmail", Gmail));
            command.Parameters.Add(new SqlParameter("@Password", Password));
          
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
