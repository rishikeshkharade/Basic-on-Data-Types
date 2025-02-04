using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Basic_on_Data_Types.Anagram
{
    public class Anagram
    {
        public void CheckAnagram()
        {
            Console.WriteLine("Enter the String 1: ");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter the String 2: ");
            string input2 = Console.ReadLine();

            if (AnagramLogic(input1, input2))
            {
                Console.WriteLine("Strings are Anagram");
            }
            else
            {
                Console.WriteLine("Strings are not Anagram");
            }
        }

        static bool AnagramLogic(string str1, string str2)
        {
           str1 = str1.Replace(" ","").ToLower();
           str2 = str2.Replace(" ","").ToLower();

            if (str1.Length != str2.Length)
                return false;

            char[] charArray1 = str1.ToCharArray();
            char[] charArray2 = str2.ToCharArray();

            Array.Sort(charArray1);
            Array.Sort(charArray2);


            return new string(charArray1) == new string(charArray2);
        }
    }
}
