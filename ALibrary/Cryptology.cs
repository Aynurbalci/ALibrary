using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ALibrary
{
    class Cryptology
    {
       public static string SezarEncryption(string text,int key)
        {
            char[] a = text.ToCharArray();
            string Encryption = null;
            foreach(char item in a)
            {
                Encryption += Convert.ToChar(item + key);
            }
            return Encryption;
        }

       public static string SezarDecryption(string text,int key)
        {
            char[] a = text.ToCharArray();
            string Decryption = null;
            foreach(char item in a)
            {
                Decryption += Convert.ToChar(item - key);
            }
            return Decryption;
        }
        

    }
}
