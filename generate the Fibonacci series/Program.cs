using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generate_the_Fibonacci_series
{
    class fibonacciSeries
    {
        static void Main()
        {
            Console.WriteLine(" Fibonacci Series ");

            Console.WriteLine("Enter the numbers in turms of series ");
            int numbers = int.Parse(Console.ReadLine());

            gendretfibonacciseries(numbers);

            Console.ReadLine();

        }
        static void gendretfibonacciseries(int n)
        {
            int firstnumbers = 0;
            int secondnumbers = 1;

            Console.WriteLine($" {firstnumbers} : {secondnumbers}");

            for(int i = 2; i < n; i++)
            {
                int nextnum = firstnumbers + secondnumbers;
                Console.Write($" {nextnum}");

                firstnumbers = secondnumbers;
                secondnumbers = nextnum;
            }
            Console.ReadLine() ;
        }
    }
}
