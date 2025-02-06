using System;

namespace Basic_on_Data_Types
{
    public class Calculator
    {
        public double Addition(double x, double y)
        {
            return x + y;
        }

        public double Subtraction(double x, double y)
        {
            return x - y;
        }

        public double Multiplication(double x, double y)
        {
            return x * y;
        }

        public double Division(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Can't divide by zero.");
            }
            return x / y;
        }

        public void ShowMenu()
        {
            Console.WriteLine("Calculator Menu");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
        }

        public void Run()
        {
            while (true)
            {
                ShowMenu();
                string input = Console.ReadLine();
                int choice;

                
                if (!int.TryParse(input, out choice) || choice < 1 || choice > 5)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                    continue;
                }

                if (choice == 5)
                {
                    Console.WriteLine("Exiting the calculator.");
                    break;
                }

                Console.Write("Enter the first number: ");
                double x, y;

               
                if (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                Console.Write("Enter the second number: ");

                // Validate input for the second number
                if (!double.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                try
                {
                    double result = 0;

                    switch (choice)
                    {
                        case 1:
                            result = Addition(x, y);
                            Console.WriteLine($"Result: {x} + {y} = {result}");
                            break;

                        case 2:
                            result = Subtraction(x, y);
                            Console.WriteLine($"Result: {x} - {y} = {result}");
                            break;

                        case 3:
                            result = Multiplication(x, y);
                            Console.WriteLine($"Result: {x} * {y} = {result}");
                            break;

                        case 4:
                            result = Division(x, y);
                            Console.WriteLine($"Result: {x} / {y} = {result}");
                            break;
                    }
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}