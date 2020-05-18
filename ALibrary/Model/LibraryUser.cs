using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALibrary.Model
{
   public class LibraryUser
    {
        public String Id { get; set; }
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
    }
}
