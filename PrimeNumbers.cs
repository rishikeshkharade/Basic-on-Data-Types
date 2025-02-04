using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Basic_on_Data_Types
{
    public class PrimeNumbers
    {
        public void Prime()
        {
            Console.Write("Enter the Number");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Prime numbers up to" + n + ":");

            for (int i = 2; i < n; i++)
            {
                if (IsPrime(i))
                    Console.WriteLine(i);
            }
        }

        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number == 2)
                return true;
            if (number % 2 == 0)
                return false;

            for (int i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0)
                    return false;

            }
            return true;
        }
    }
}
