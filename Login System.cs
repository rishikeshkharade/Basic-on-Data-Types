using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Basic_on_Data_Types
{
    public class Login_System
    {
        const string username = "rishikesh";
        const string password = "rishi";
        int maxLimit = 3;

        public void Login()
        {
            for (int i = 0; i <= maxLimit; i++)
            {
                if (i==maxLimit)
                {
                    Console.WriteLine("Your account locked you exceeds max limit");
                    break;
                }
                Console.WriteLine("Enter username: ");
                string user_name = Console.ReadLine();

                Console.WriteLine("Enter Password: ");
                string password_name = Console.ReadLine();

                
                if (user_name == username && password == password_name)
                {
                    Console.WriteLine("Successful Login");
                    break;
                }
                if (user_name != username)
                {
                    Console.WriteLine("Incorrect username");
                }
                else if (password_name != password)
                {
                    Console.WriteLine("Incorret password");
                }
                
            }
        }
    }
}
