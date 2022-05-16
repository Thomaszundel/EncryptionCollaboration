using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionCollaboration
{
    internal class Encryption
    {
        int secretKey =
        
        public string Encrypt(string unencrypted)
        {
            string s = unencrypted;
            int total = 0;
           
            foreach (char c in s)
            {
                int singleLetter = 0;
                singleLetter = Convert.ToInt32(c);
                total += singleLetter;
            }
            string namedNumber = total.ToString();
            
            return namedNumber;

        }
        public string Decrypt(string encrypted)
        {

        }
    }        
}
