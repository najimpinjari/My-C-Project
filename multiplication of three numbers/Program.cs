using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_of_three_numbers
{
    class Program
    {   
        //this is the beggining of a program 
        static void Main(string[] args) // tis is the main method where the program execution starrts 
        {
            //declarationof variables to strore threee numbers 
            int num1 , num2 , num3 ;

            //prompting the user to input the first number to multipley
            Console.WriteLine("input the first number to multiply; ");
            //Reding the first number enterd by the user and converting it to an interger
            num1 = Convert.ToInt32(Console.ReadLine());

            //prompting the user to input the second number to multipley
            Console.WriteLine("input the seconnd number to multiply; ");
            //Reding the first number enterd by the user and converting it to an interger
            num2 = Convert.ToInt32(Console.ReadLine());

            //prompting the user to input the third number to multipley
            Console.WriteLine("input the third number to multiply; ");
            //Reding the first number enterd by the user and converting it to an interger
            num3 = Convert.ToInt32(Console.ReadLine());

            //calculating the result of multiplying the three numbers

            int result = num1 * num2 * num3 ;

            //displaying the multiplication formula and the result to the console 
            Console.WriteLine($" Output : {num1} X {num2} X {num3} = {result}");


            Console.ReadLine();




        }
    }
}
