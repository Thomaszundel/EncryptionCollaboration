using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionCollaboration
{
    internal class Encryption
    {
        int secretKey = 400;
        
        public string Encrypt(string unencrypted)
        {
            string s = unencrypted;
            int total = 0;
            string allLetters ="";
            foreach (char c in s)
            {
                int singleLetter = 0;
                singleLetter = Convert.ToInt32(c);
                
                


                total += singleLetter;

                allLetters += (singleLetter + secretKey).ToString()+" ";

                
                

            }
            
            string namedNumber = total.ToString();
            
            return namedNumber +" "+ allLetters;

        }
        //public string Decrypt(string encrypted)
        //{
        //    string ASCIICapitalKeys = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        //    string ASCIILowerKeys = "abcdefghijklmnopqrstuvwxyz";
        //    string ASCIINumberKeys = "0123456789";

        //    foreach (char c in ASCIICapitalKeys)
        //    {
        //        int singleKey = 0;
        //        singleKey = Convert.ToInt32(c);

        //    }
        //}
    }
        
}
