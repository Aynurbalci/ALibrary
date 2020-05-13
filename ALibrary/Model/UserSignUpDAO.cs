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
    public class UserSignUpDAO
    {
       public String UserNames {get;set;}
       public String UserSurname {get;set;}
       public String Gender {get;set;}
       public DateTime DateOfBirth {get;set;}
       public String EducationStatus {get;set;}
       public String MaritalStatus {get;set;}
       public String BookTypes {get;set;}
       public String IdentificationNumber {get;set;}
       public int HowManyBooks {get;set;}
       public String Address {get;set;}
       public String AddressType {get;set;}
       public String LoginUsername {get;set;}
       public String Gmails {get;set;}
       public String PhoneNumber {get;set;}
        
        private SqlConnection connection = new SqlConnection(Helper.ConnectionKey);

        public List<string> GetErrors() {
            List<string> errors = new List<string>();

            if (Helper.AynurIsStringEmpty(UserNames))
            {
                errors.Add("Username is required");
            }

            if (Helper.AynurIsStringEmpty(UserSurname))
            {
                errors.Add("UserSurname is required");
            }

            if (Helper.AynurIsStringEmpty(Gender))
            {
                errors.Add("Gender is required");
            }
            if (Helper.AynurIsStringEmpty(EducationStatus))
            {
                errors.Add("EducationStatus is required");
            }

            if (Helper.AynurIsStringEmpty(MaritalStatus))
            {
                errors.Add("MaritalStatus is required");
            }

            if (Helper.AynurIsStringEmpty(BookTypes))
            {
                errors.Add("BookTypes is required");
            }


            if (Helper.AynurIsStringEmpty(Address))
            {
                errors.Add("Address is required");
            }

            if (Helper.AynurIsStringEmpty(AddressType))
            {
                errors.Add("AddressType is required");
            }

            if (Helper.AynurIsStringEmpty(LoginUsername))
            {
                errors.Add("LoginUsername is required");
            }

            if (Helper.AynurIsStringEmpty(Gmails))
            {
                errors.Add("Gmails is required");
            }

            if (Helper.AynurIsStringEmpty(PhoneNumber))
            {
                errors.Add("PhoneNumber is required");
            }


            return errors;
        }

        public DataTable GetAllUserSignUp()
        {
            OpenConnection();
            string key = "SELECT * from UserSignUp";
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

            string cmd = "INSERT INTO UserSignUp VALUES(@UserNames,@UserSurname,@Gender,@DateOfBirth"
                + ",@EducationStatus,@MaritalStatus,@BookTypes,@IdentificationNumber,@HowManyBooks,@Address,@AddressType,@LoginUsername,@Gmails,@PhoneNumber)";

            SqlCommand command = new SqlCommand(cmd, connection);
            command.Parameters.Add(new SqlParameter("@UserNames", UserNames));
            command.Parameters.Add(new SqlParameter("@UserSurname", UserSurname));
            command.Parameters.Add(new SqlParameter("@Gender", Gender));
            command.Parameters.Add(new SqlParameter("@DateOfBirth", DateOfBirth));
            command.Parameters.Add(new SqlParameter("@EducationStatus", EducationStatus));
            command.Parameters.Add(new SqlParameter("@MaritalStatus", MaritalStatus));
            command.Parameters.Add(new SqlParameter("@BookTypes", BookTypes));
            command.Parameters.Add(new SqlParameter("@IdentificationNumber", IdentificationNumber));
            command.Parameters.Add(new SqlParameter("@HowManyBooks", HowManyBooks));
            command.Parameters.Add(new SqlParameter("@Address", Address));
            command.Parameters.Add(new SqlParameter("@AddressType", AddressType));
            command.Parameters.Add(new SqlParameter("@LoginUsername", LoginUsername));
            command.Parameters.Add(new SqlParameter("@Gmails", Gmails));
            command.Parameters.Add(new SqlParameter("@PhoneNumber", PhoneNumber));
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
