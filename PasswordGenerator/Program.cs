using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Password Generator!");

            // Get user input for password length
            Console.Write("Enter desired password length: ");
            int passwordLength;
            while (!int.TryParse(Console.ReadLine(), out passwordLength) || passwordLength <= 0)
            {
                Console.WriteLine("Please enter a valid positive integer for password length: ");
            }

            // Get user input for character types to include
            string charTypes = "";
            Console.Write("Include uppercase letters? (y/n): ");
            if (Console.ReadLine().ToLower() == "y")
                charTypes += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            Console.Write("Include lowercase letters? (y/n): ");
            if (Console.ReadLine().ToLower() == "y")
                charTypes += "abcdefghijklmnopqrstuvwxyz";

            Console.Write("Include numbers? (y/n): ");
            if (Console.ReadLine().ToLower() == "y")
                charTypes += "0123456789";

            Console.Write("Include special characters? (y/n): ");
            if (Console.ReadLine().ToLower() == "y")
                charTypes += "!@#$%^&*()-_+=<>?";

            if (charTypes == "")
            {
                Console.WriteLine("You must choose at least one character type.");
                return;
            }

            // Generate password
            string password = GeneratePassword(passwordLength, charTypes);

            // Display generated password
            Console.WriteLine("\nGenerated Password: " + password);

            Console.ReadLine();
        }

        static string GeneratePassword(int length, string charSet)
        {
            StringBuilder password = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(charSet.Length);
                password.Append(charSet[index]);
            }

            return password.ToString();
        }
    }
}

//namespace PasswordGenerator
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // when we open the application then show 
//            Console.WriteLine("welcome to password generator");

//            //get the user input for password lenth 
//            Console.WriteLine("enter desire password lenth :  ");
//            int passwordlenth; //initialize

//            while (!int.TryParse(Console.ReadLine(),out passwordlenth ) || passwordlenth <= 0)
//            {
//                Console.WriteLine("please enter valid position integer for password lenth ");
//            }

//            //get user input for charecheter type include   

//            string chartype;
//            Console.Write("include uppercase letter ?   (y/n) : ");
//            if (Console.ReadLine().ToLower() == "y")
//                chartype += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

//            Console.Write("include lowercase letter  (y/n)");
//            if (Console.ReadLine().ToUpper() == "y")
//                chartype += "abcdefghijklmnopqrstuvwxyz";

//            Console.Write("include number (y/n) : ");
//            if (Console.ReadLine().ToLower() == "y")
//                chartype += "1234567890";

//            Console.WriteLine("include special charecters (y/n) : ");
//            if (Console.ReadLine().ToLower() == "y");
//                chartype += "!@#$%^&*()-_+=<>?";


//            if (chartype == " ")
//            {
//                Console.WriteLine("you must chose atlist one charecheter type");
//                return;
//            }

//            //generet password 
//            string password = GeneretPassword(passwordlenth, chartype);

//            //disply generate password 

//            Console.WriteLine("\n GeneretPassword : " + password);


//        }
//        static string GeneretPassword(int lenth, string charset)
//        {
//            StringBuilder password = new StringBuilder();
//            Random random = new Random();

//            for (int i = 0; i < lenth; i++)
//            {
//                int index = random.Next(charset.Length);
//                password.Append(charset[index]);
//            }
//            return password.ToString();
//        }

//    }
//}
