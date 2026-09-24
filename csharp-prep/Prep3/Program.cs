using System;
using System.Globalization;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        bool done = false;

        while (!done)
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            int guesses = int.Parse(guess);
            
            if (guesses > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guesses < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.Write("Are you done (y/n)? ");
                done = Console.ReadLine().ToLower() == "y";
            }
        }
    }
}