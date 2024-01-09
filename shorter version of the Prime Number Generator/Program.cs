using System;
using System.Collections.Generic;

class PrimeNumberGenerator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Prime Number Generator!");

        // Get user input for the range
        int start = GetInput("Enter the starting number (must be greater than 1): ", 2);
        int end = GetInput("Enter the ending number: ", start);

        // Generate and display prime numbers
        List<int> primes = GeneratePrimes(start, end);
        DisplayPrimes(primes);

        Console.WriteLine("Thank you for using the Prime Number Generator!");
    }

    static int GetInput(string prompt, int minValue)
    {
        int input;
        do
        {
            Console.Write(prompt);
        } while (!int.TryParse(Console.ReadLine(), out input) || input < minValue);

        return input;
    }

    static List<int> GeneratePrimes(int start, int end)
    {
        List<int> primes = new List<int>();
        bool[] isPrime = new bool[end + 1];

        for (int i = 2; i <= end; i++)
        {
            if (!isPrime[i])
            {
                primes.Add(i);

                for (int j = i * i; j <= end; j += i)
                {
                    isPrime[j] = true;
                }
            }
        }

        return primes;
    }

    static void DisplayPrimes(List<int> primes)
    {
        Console.WriteLine($"Prime numbers: {string.Join(", ", primes)}");
        Console.ReadLine();
    }

    
}
