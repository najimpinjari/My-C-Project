using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            // Prompt the user for their name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Prompt the user for their age
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            // Calculate age in months
            int ageInMonths = age * 12;

            // Display a greeting and age information
            Console.WriteLine($"Hello, {name}!");
            Console.WriteLine($"You are {age} years old, which is approximately {ageInMonths} months.");

            // Wait for user input before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
