using System;

class Program
{
    static void Main(string[] args)
    {
        int currentYear = DateTime.Now.Year;

        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        int birthYear = PromptUserBirthYear();


        DisplayResult(userName, squaredNumber, currentYear, birthYear);
        
        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter a name: ");
            string name = Console.ReadLine();

            return name;
        }
        
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        static int PromptUserBirthYear()
        {
            Console.Write("Please enter the year you were born: ");
            int birthYear = int.Parse(Console.ReadLine()!);

            return birthYear;
        }

        static int SquareNumber(int number)
        {
            int squaredNumber = number * number;

            return squaredNumber;
        }

        static void DisplayResult(string name, int squaredNumber, int currentYear, int birthYear)
        {
            Console.WriteLine($"{name}, the square of your number is: {squaredNumber}.");
            Console.WriteLine($"{name}, you will turn {currentYear - birthYear} this year.");
        }
    }
}