using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_on_Data_Types
{
    public class Unique_Character
    {
        public void hasUniqueCharacters()
        {
            bool hasunique = UniqueChar("Rishikesh");
            if (hasunique)
            {
                Console.WriteLine("Unique characters are present in String");
            }
            else
            {
                Console.WriteLine("Duplicate Characters are present in String");
            }
        }
        public bool UniqueChar(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
