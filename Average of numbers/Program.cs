using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_of_numbers
{
    class Program //the main class of the exercise 
    {
        static void Main(string[] args) // this this the main method wher the program executing starts 
        {
            //firstly we declarationof variables to store four numbers
            
            double number1, number2, number3, number4;

            //prompting the user to enter the first number
            Console.WriteLine("please Enter yout first number : ");
            // reding the first number enterd by the userand convering it to a double
            number1 = Convert.ToDouble(Console.ReadLine());

            //prompting the user to enter the second number
            Console.WriteLine("please Enter yout second number : ");
            // reding the first number enterd by the userand convering it to a double
            number2 = Convert.ToDouble(Console.ReadLine());

            //prompting the user to enter the third number
            Console.WriteLine("please Enter yout third number : ");
            // reding the first number enterd by the userand convering it to a double
            number3 = Convert.ToDouble(Console.ReadLine());

            //prompting the user to enter the fourth number
            Console.WriteLine("please Enter yout fourth number : ");
            // reding the first number enterd by the userand convering it to a double
            number4 = Convert.ToDouble(Console.ReadLine());

            //calculate the average of numbers now four number we have 

            double result = number1 + number2 + number3 + number4 / 4;
            
            //displaying the average of the four numbers to the console
            Console.WriteLine($"the average of four numbers is : {number1} ,{number2} , {number3} , {number4} = {result} ");


            Console.ReadKey();
        }
    }
}
