using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionCollaboration
{
    internal class Encryption
    {
        int secretKey = 0;
        
        public string Encrypt(string unencrypted)
        {
            List<int> diffrenceValues = new List<int>();
           
            string s = unencrypted;
            int total = 0;
            string allLetters ="";
            foreach (char c in s)
            {
                int numberOne = 0;
                int diffrence = 0;
                int singleLetter = 0;
                singleLetter = Convert.ToInt32(c);
                
                


                total += singleLetter;

                numberOne = total - singleLetter;

                diffrence = numberOne - singleLetter;

                if(diffrence > 0)
                {
                    diffrenceValues.Add(diffrence);
                }
                



                allLetters += (singleLetter + secretKey).ToString()+" ";

                
                

            }
            
            string namedNumber = total.ToString();

            string diffrenceValue ="";
            foreach (int diffrence in diffrenceValues)
            {
                
                diffrenceValue += diffrence.ToString() + " " ;
            }

            return namedNumber + " " + diffrenceValue;

        }
        public string Decrypt(string encrypted)
        {
            int diffrence = 0;
            int length = 0;
            int total = 0;
            string[] values;

            values = encrypted.Split(' ');

            total =  int.Parse(values[0]);

            length = values.Length;

            diffrence = int.Parse(values[length - 1]);

            List<string> Letterlist = new List<string>();
            for (int i=length-1; i>0;i--)
            {
                int firstStep =  total + int.Parse(values[i]);
                int secondStep = firstStep / 2;
                int letter = total - secondStep;
                total = secondStep;
                Letterlist.Add(letter.ToString());
                if(i == 1)
                {
                    Letterlist.Add(total.ToString());
                }
            }

            string AllLetters = "";
           foreach(string letter in Letterlist)
            {
                AllLetters += letter + " ";
            }


            return AllLetters;
        }
    }
        
}
