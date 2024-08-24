using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Practice_problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            // var thirdHighestSalary = employees
            //         .Select(e => e.Salary)                 // Select only the salaries
            //         .Distinct()                            // Ensure unique salaries
            //         .OrderByDescending(s => s)            // Order salaries in descending order
            //         .Skip(2)                               // Skip the first two highest salaries
            //         .Take(1)                               // Take the next one (i.e., the third highest)
            //         .SingleOrDefault();                    // Get the single result or default if none

            // Console.WriteLine($"The third highest salary is: {thirdHighestSalary}");

            // Console.WriteLine("Please write your string");
            // string name = Console.ReadLine();

            // string rev = null;

            // for (int i = name.Length - 1; i >= 0; i--)
            // {
            //     rev += name[i];
            // }
            // Console.WriteLine(rev);

            // Console.ReadLine();



            // //reverstring 

            // Console.Write("Enter a sentence: ");
            // string sentence = Console.ReadLine();  // Get the sentence from the user

            // string[] splitsentnce = sentence.Split();
            // string rev = "";

            // for (int i = splitsentnce.Length - 1; i >= 0; i--)
            // {
            //     rev += splitsentnce[i] + " ";
            // }

            // rev = rev.Trim();
            // Console.WriteLine(rev);

            // Console.ReadLine();



            //// PALINDROME

            // Console.WriteLine("please enter your string");
            // string input = Console.ReadLine();

            // char[] charinput = input.ToCharArray();

            // string output = "";

            // for (int i = charinput.Length - 1; i >= 0; i--)
            // {
            //     output += charinput[i];
            // }
            // Console.WriteLine(output);

            // if (input == output)
            // {
            //     Console.WriteLine("this is a palindrom");
            // }
            // else
            // {
            //     Console.WriteLine(" this is not a paindrom");
            // }
            // Console.ReadLine();

            //factoreal

            //int num, fact = 1;

            //Console.WriteLine("enter number");
            //num = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= num; i++)
            //{
            //    fact = fact * i;
            //}
            //Console.WriteLine($" this is the factoreal {fact}");

            //Console.ReadLine();

            //fibonacci seris 

            // Console.Write("Enter the number of terms: ");
            // string input = Console.ReadLine();  // Read user input
            // int terms;

            //// Validate and parse input
            // if (int.TryParse(input, out terms) && terms > 0)
            // {
            //     //Input is valid and positive
            //     int first = 0, second = 1;

            //     Console.WriteLine("Fibonacci Series:");
            //     for (int i = 0; i < terms; i++)
            //     {
            //         Console.Write(first + " ");
            //         int next = first + second;
            //         first = second;
            //         second = next;
            //     }
            // }
            // else
            // {
            //    // Input is invalid or non - positive
            //     Console.WriteLine("Please enter a valid positive integer.");
            // }


            //int[] number = { 3, 9, 1, 5, 12 };

            //Array.Reverse(number);

            //Console.WriteLine(number);

            //foreach( var item in number)
            //{
            //    Console.WriteLine(item + " ");
            //}

            //int max = number[0];

            //int min = number[0];

            //foreach( var num in number)
            //{
            //    if (num > max);
            //         max = num;

            //    if (num < min) ;
            //         min = num;
            //}

            //Console.WriteLine(max);
            //Console.WriteLine(min);

            //int[] number = { 3, 9, 1, 5, 12 };

            //  int sum = 0;
            //foreach( int item in number)
            //{
            //    sum += item;
            //}
            // Console.WriteLine(sum);

            ////4. Find the Second Largest Element in an Array
            //int[] numbers = { 1, 2, 3, 4, 5, };

            //int max = int.MaxValue;

            //int secondmax = int.MinValue;

            //foreach( int item in numbers)
            //{
            //    if( item > max)
            //    {
            //        secondmax = max;
            //            max = item;
            //    }
            //    else if ( item < max)
            //    {
            //        secondmax = item;
            //    }

            //}
            //Console.WriteLine($"second larges element {secondmax} ");

            Console.WriteLine("pleaes enter your number ");
            int num = Convert.ToInt32(Console.ReadLine());

            bool isprime = true;

            if (num <= 1)
            {
                isprime = false;
            }
            else
            {
                for (int i = 2  ; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
            }
            Console.WriteLine($"{num} is {(isprime ? "a Prime" : "not a Prime")} number.");













            Console.ReadLine(); // Keep the console window open


        }
    }
}
