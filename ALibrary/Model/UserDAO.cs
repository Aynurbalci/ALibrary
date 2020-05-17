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
    public class UserDAO
    {
        public int Id { get; set; }
        public String UserName { get; set; }
        public String Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String EducationStatus { get; set; }
        public String MaritalStatus { get; set; }
        public String BookTypes { get; set; }
        public String IdentificationNumber { get; set; }
        public String Address { get; set; }
        public String AddressType { get; set; }
        public String Gmail { get; set; }
        public String MobilePhone { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Password { get; set; }



        private SqlConnection connection = new SqlConnection(Helper.ConnectionKey);

        public List<string> GetErrors()
        {
            List<string> errors = new List<string>();

            if (Helper.AynurIsStringEmpty(UserName))
            {
                errors.Add("Username is required");
            }

            if (Helper.AynurIsStringEmpty(Password))
            {
                errors.Add("Password is required");
            }

            //if (Helper.AynurIsStringEmpty(Gender))
            //{
            //    errors.Add("Gender is required");
            //}
            //if (Helper.AynurIsStringEmpty(EducationStatus))
            //{
            //    errors.Add("EducationStatus is required");
            //}

            //if (Helper.AynurIsStringEmpty(MaritalStatus))
            //{
            //    errors.Add("MaritalStatus is required");
            //}

            //if (Helper.AynurIsStringEmpty(BookTypes))
            //{
            //    errors.Add("BookTypes is required");
            //}


            //if (Helper.AynurIsStringEmpty(Address))
            //{
            //    errors.Add("Address is required");
            //}

            //if (Helper.AynurIsStringEmpty(AddressType))
            //{
            //    errors.Add("AddressType is required");
            //}


            if (Helper.AynurIsStringEmpty(Gmail))
            {
                errors.Add("Gmail is required");
            }

            //if (Helper.AynurIsStringEmpty(MobilePhone))
            //{
            //    errors.Add("PhoneNumber is required");
            //}
            //if (Helper.AynurIsStringEmpty(FirstName))
            //{
            //    errors.Add("FirstName is required");
            //}

            //if (Helper.AynurIsStringEmpty(LastName))
            //{
            //    errors.Add("LastName is required");
            //}



            return errors;
        }

        public DataTable GetAllUserSignUp()
        {
            OpenConnection();
            string key = "SELECT * FROM LibraryUser";
            SqlCommand command = new SqlCommand(key, connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CloseConnection();
            return dt;
        }


        public bool IsUserExist(string username, string password)
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
            return dt.Rows.Count > 0;
        }



        public void Insert()
        {
            OpenConnection();

            string cmd = @"INSERT INTO [dbo].[LibraryUser]
           ([UserName]
           ,[Gender]
           ,[EducationStatus]
           ,[MaritalStatus]
           ,[BookType]
           ,[IdentificationNumber]
           ,[Address]
           ,[AddressType]
           ,[Gmail]
           ,[MobilePhone]
           ,[FirstName]
           ,[LastName]
           ,[Password])
     VALUES
           (@UserName
           ,@Gender
           ,@EducationStatus
           ,@MaritalStatus
           ,@BookType
           ,@IdentificationNumber
           ,@Address
           ,@AddressType
           ,@Gmail
           ,@MobilePhone
           ,@FirstName
           ,@LastName
           ,@Password)";



            SqlCommand command = new SqlCommand(cmd, connection);
            command.Parameters.Add(new SqlParameter("@UserName", UserName));
            command.Parameters.Add(new SqlParameter("@Gender", Gender));          
            command.Parameters.Add(new SqlParameter("@DateOfBirth", DateOfBirth));
            command.Parameters.Add(new SqlParameter("@EducationStatus", EducationStatus));
            command.Parameters.Add(new SqlParameter("@MaritalStatus", MaritalStatus));
            command.Parameters.Add(new SqlParameter("@BookType", BookTypes));
            command.Parameters.Add(new SqlParameter("@IdentificationNumber", IdentificationNumber));
            command.Parameters.Add(new SqlParameter("@Address", Address));
            command.Parameters.Add(new SqlParameter("@AddressType", AddressType));
            command.Parameters.Add(new SqlParameter("@Gmail", Gmail));
            command.Parameters.Add(new SqlParameter("@MobilePhone", MobilePhone));
            command.Parameters.Add(new SqlParameter("@FirstName", FirstName));
            command.Parameters.Add(new SqlParameter("@LastName", LastName));
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
