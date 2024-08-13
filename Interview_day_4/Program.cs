using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_day_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            //write a program for reverce string 

            Console.WriteLine("Enter String  + "); //for user to enter a string
            string name = Console.ReadLine();  //for read the string and store in name variable 

            string rev = null; // rev we initialized to store the reversed version 

            for (int i = name.Length - 1; i >= 0; i--) //A for loop is used to iterate through 
                                                       //the input string name from the last character to the first.
            {
                rev += name[i];                         //name.Length - 1 gives the index of the last character.
            }
            Console.WriteLine(rev);

            Console.ReadLine();

        }
    }
}
