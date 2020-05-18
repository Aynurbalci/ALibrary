using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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
        public String BookType { get; set; }
        public String IdentificationNumber { get; set; }
        public String Address { get; set; }
        public String AddressType { get; set; }
        public String Gmail { get; set; }
        public String MobilePhone { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Password { get; set; }
        public string Picture { get; set; }



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


        public LibraryUser GetUser(string username, string password)
        {
            OpenConnection();
            LibraryUser libraryUser = new LibraryUser();
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
                return null;
            }

            libraryUser.Id = dt.Rows[0]["Id"].ToString();
            libraryUser.UserName = dt.Rows[0]["UserName"].ToString();
            libraryUser.Password = dt.Rows[0]["Password"].ToString();
            libraryUser.Gmail = dt.Rows[0]["Gmail"].ToString();
            libraryUser.Picture = dt.Rows[0]["Picture"].ToString();
            libraryUser.FirstName = dt.Rows[0]["FirstName"].ToString();
            libraryUser.LastName = dt.Rows[0]["LastName"].ToString();
            libraryUser.MobilePhone = dt.Rows[0]["MobilePhone"].ToString();


            return libraryUser;
        }

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


        public DataTable GetAllUserBooks(LibraryUser logginUser)
        {
            OpenConnection();
            string key = "SELECT * FROM UserBook WHERE UserId=@UserId";
            SqlCommand command = new SqlCommand(key, connection);
            command.Parameters.AddWithValue("UserId",logginUser.Id);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataTable dataTable = null;
            foreach (DataRow row in dt.Rows)
            {
                DataTable temp = GetBook(row["BookId"].ToString());

                if (temp == null) {
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
           ,[Password]
           ,[Picture]    )
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
           ,@Password
            ,@Picture)";



            SqlCommand command = new SqlCommand(cmd, connection);
            command.Parameters.Add(new SqlParameter("@UserName", UserName));
            command.Parameters.Add(new SqlParameter("@Gender", Gender));
            command.Parameters.Add(new SqlParameter("@DateOfBirth", DateOfBirth));
            command.Parameters.Add(new SqlParameter("@EducationStatus", EducationStatus));
            command.Parameters.Add(new SqlParameter("@MaritalStatus", MaritalStatus));
            command.Parameters.Add(new SqlParameter("@BookType", BookType));
            command.Parameters.Add(new SqlParameter("@IdentificationNumber", IdentificationNumber));
            command.Parameters.Add(new SqlParameter("@Address", Address));
            command.Parameters.Add(new SqlParameter("@AddressType", AddressType));
            command.Parameters.Add(new SqlParameter("@Gmail", Gmail));
            command.Parameters.Add(new SqlParameter("@MobilePhone", MobilePhone));
            command.Parameters.Add(new SqlParameter("@FirstName", FirstName));
            command.Parameters.Add(new SqlParameter("@LastName", LastName));
            command.Parameters.Add(new SqlParameter("@Password", Password));
            command.Parameters.Add(new SqlParameter("@Picture", Picture));



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
        public void Delete(int id)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand(
                "Delete from LibraryUser where Id=@id", connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            CloseConnection();




        }
        public void Updated()
        {
            if (Id < 1)
            {
                return;
            }

            string cmd = @"UPDATE [dbo].[LibraryUser]
                           SET [UserName] = @UserName,
                           [Gender] = @Gender,
                           [EducationStatus] = @EducationStatus,
                           [MaritalStatus] = @MaritalStatus,
                           [BookType] = @BookType,
                           [IdentificationNumber] = @IdentificationNumber,
                           [Address] = @Address,
                           [AddressType] = @AddressType,
                           [Gmail] = @Gmail,
                           [MobilePhone] = @MobilePhone,
                           [FirstName] = @FirstName,
                           [LastName] = @LastName,
                           [Password] = @Password,
                           [Picture] = @Picture
                         WHERE [Id] = @id";

            OpenConnection();
            SqlCommand command = new SqlCommand(cmd, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@EducationStatus", EducationStatus);
            command.Parameters.AddWithValue("@MaritalStatus", MaritalStatus);
            command.Parameters.AddWithValue("@BookType", BookType);
            command.Parameters.AddWithValue("@IdentificationNumber", IdentificationNumber);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@AddressType", AddressType);
            command.Parameters.AddWithValue("@Gmail", Gmail);
            command.Parameters.AddWithValue("@MobilePhone", MobilePhone);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Picture", Picture);

            command.Parameters.Add("@id", SqlDbType.Int);
            command.Parameters["@id"].Value = Id;

            command.ExecuteNonQuery();

            CloseConnection();




        }
    }
}
