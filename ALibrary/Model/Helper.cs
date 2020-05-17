using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALibrary.Model
{
   public class Helper
    {
        public static readonly string ConnectionKey = "server=(localdb)\\mssqllocaldb;Database=AynurLibraryDb;Integrated security = true";

        public static  bool AynurIsStringEmpty(string a)
        {
            return a == null || a.Trim().Length == 0;
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
