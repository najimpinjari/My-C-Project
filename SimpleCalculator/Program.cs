using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("\n SimpleCalculator");
                Console.WriteLine("1 Addition");
                Console.WriteLine("2 Substraction");
                Console.WriteLine("3 Multification");
                Console.WriteLine("4 Division");
                Console.WriteLine("5 Exit");
                Console.WriteLine("Select An Option ");

                string  option = Console.ReadLine();

                if (option == "5")
                {
                    break;  
                }

                Console.WriteLine("Enter First Number ");
                double Number1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Second Number ");
                double Number2 = double.Parse(Console.ReadLine());

                double result = 0;

                bool validOption = true;

                switch (option) 
                {
                    case "1":
                        result = Number1 + Number2;
                        break;
                    case "2":
                        result = Number1 - Number2;
                        break;
                    case "3":
                        result = Number1 * Number2;
                        break;
                    case "4":
                        if (Number2 != 0)
                        {
                            result = Number2 / Number1;
                        }
                        else 
                        {
                            Console.WriteLine("Cannot divided by Zero ");
                            validOption = false;
                        }
                        break;
                    default: Console.WriteLine("Invalid Option Please Try Again");
                        validOption = false;
                        break;
                }

                if (validOption)
                {
                    Console.WriteLine($" Result = {result}");
                }
            }
        }
    }
}
