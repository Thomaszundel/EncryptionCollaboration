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
            //set values
            List<int> diffrenceValues = new List<int>();
            string s = unencrypted;
            int total = 0;
            

            foreach (char c in s)
            {
                //set values
                int numberOne = 0;
                int diffrence = 0;
                int singleLetter = 0;

                //convert each letter into char 
                singleLetter = Convert.ToInt32(c);

                //do math to get diffrences
                total += singleLetter;
                numberOne = total - singleLetter;
                diffrence = numberOne - singleLetter;

                //edge case to add last number
                if(diffrence > 0)
                {
                    diffrenceValues.Add(diffrence);
                }
            }

            //getting total sum
            string namedNumber = total.ToString();

            //making diffrence vaules list into a single string
            string diffrenceValue ="";
            foreach (int diffrence in diffrenceValues)
            {
                
                diffrenceValue += diffrence.ToString() + " " ;
            }

            return namedNumber + " " + diffrenceValue;

        }
        public string Decrypt(string encrypted)
        {
            //setting values
            int diffrence = 0;
            int length = 0;
            int total = 0;
            string[] values;
            List<string> Letterlist = new List<string>();

            //splitting values up into array
            values = encrypted.Split(' ');

            //taking some values from the array
            total =  int.Parse(values[0]);
            length = values.Length;
            diffrence = int.Parse(values[length - 1]);

            //doing math to get original ASCII numbers and adding them to a list
            for (int i=length-1; i>0 ;i--)
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

            //taking ASCII list and turning back into Char
            string AllLetters = "";
           for(int i = Letterlist.Count;i > 0; i--)
            {
                string letter = Letterlist[i - 1];
                char letterChar = Convert.ToChar(int.Parse(letter));

                AllLetters += letterChar;
            }


            return AllLetters;
        }
    }
        
}
