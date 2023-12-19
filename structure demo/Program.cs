using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structure_demo
{
     struct Program
    {   

        public void fank1() //method onw 
        {
            Console.WriteLine("this is my first function "); //method 
        }
        static void Main(string[] args)
        {
            Program p = new Program(); //obj of fanc one class 
            p.fank1();

            Console.ReadLine();
        }
    }
}
