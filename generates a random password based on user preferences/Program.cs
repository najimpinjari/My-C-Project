using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generates_a_random_password_based_on_user_preferences
{

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Random Password Generator!");

            Console.Write("Enter the length of the password: ");
            if (int.TryParse(Console.ReadLine(), out int passwordLength) && passwordLength > 0)
            {
                Console.Write("Include uppercase letters? (y/n): ");
                bool includeUppercase = Console.ReadLine().ToLower() == "y";

                Console.Write("Include lowercase letters? (y/n): ");
                bool includeLowercase = Console.ReadLine().ToLower() == "y";

                Console.Write("Include numbers? (y/n): ");
                bool includeNumbers = Console.ReadLine().ToLower() == "y";

                Console.Write("Include special characters? (y/n): ");
                bool includeSpecialChars = Console.ReadLine().ToLower() == "y";

                string generatedPassword = GeneratePassword(passwordLength, includeUppercase, includeLowercase, includeNumbers, includeSpecialChars);

                Console.WriteLine($"\nYour randomly generated password is: {generatedPassword}");
            }
            else
            {
                Console.WriteLine("Invalid password length. Please enter a positive integer.");
            }
        }

        static string GeneratePassword(int length, bool includeUppercase, bool includeLowercase, bool includeNumbers, bool includeSpecialChars)
        {
            const string UppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string LowercaseChars = "abcdefghijklmnopqrstuvwxyz";
            const string NumberChars = "0123456789";
            const string SpecialChars = "!@#$%^&*()-=_+[]{}|;:'\",.<>/?";

            string allChars = "";
            if (includeUppercase) allChars += UppercaseChars;
            if (includeLowercase) allChars += LowercaseChars;
            if (includeNumbers) allChars += NumberChars;
            if (includeSpecialChars) allChars += SpecialChars;

            if (allChars.Length == 0)
            {
                Console.WriteLine("Please include at least one type of character.");
                return "";
            }

            Random random = new Random();
            char[] password = new char[length];

            for (int i = 0; i < length; i++)
            {
                password[i] = allChars[random.Next(allChars.Length)];
            }

            return new string(password);
        }
    }
}
