using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_on_Data_Types
{
    public class MovieTicket
    {

        int Ticket_Price = 200;
        int Child_Ticket_Price = 100;
        int Seniors_Ticket_Price = 150;

        public void Ticket_Pricing()
        {
            Console.WriteLine("Base Movie Ticket Price is 200Rs, But it can varry depend on your age and Movie Time.");
            Console.WriteLine("Please Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 0)
            {
                Console.WriteLine("Age cannot be in Negative format");
                return;
            }
            Console.WriteLine("Enter the time for you want to watch the movie:\n Enter the movie time in format of 24hrs\nEnter only the starting time (e.g. 13 or 14...)");
            int time = Convert.ToInt32(Console.ReadLine());

            if (time <= 0)
            {
                Console.WriteLine("Invalid Option");
                return ;
            }


            if (age < 12)
            {
                Console.WriteLine("We are looking for a Discount");
                if (age < 12 && (time >= 13 && time <= 16))
                {
                    Console.WriteLine("Congratulations your are applicable for the Discount\n Your Ticket price is: " + (Child_Ticket_Price - 30));
                }
                else
                {
                    Console.WriteLine("Sorry! We don't have any discount for you\n Your Ticket price is: " + Child_Ticket_Price);
                }
                Console.WriteLine("Ticket Price is: " + Child_Ticket_Price);

            }
            else if (age > 12 && age < 64)
            {
                Console.WriteLine("We are looking for a Discount");
                if ((age > 12 && age < 64) && (time >= 13 && time <= 16))
                {
                    Console.WriteLine("Congratulations your are applicable for the Discount\n Your Ticket price is: " + (Ticket_Price - 60));
                }
                else
                {
                    Console.WriteLine("Sorry! We don't have any discount for you\n Your Ticket price is: " + Ticket_Price);
                }
            }
            else
            {
                Console.WriteLine("We are looking for a Discount");
                if (time >= 13 && time <= 16)
                {
                    Console.WriteLine("Congratulations your are applicable for the Discount\n Your Ticket price is: " + (Seniors_Ticket_Price - 45));
                }
                else
                {
                    Console.WriteLine("Sorry! We don't have any discount for you\n Your Ticket price is: " + Seniors_Ticket_Price);
                }
            }


        }
    }
}
