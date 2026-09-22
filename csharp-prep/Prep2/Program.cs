using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percentage grade? ");
        string percent = Console.ReadLine();

        int percentage = int.Parse(percent);

        if (percentage >= 90)
        {
            Console.WriteLine("You got an A!");
        }
        else if (percentage >= 80)
        {
            Console.WriteLine("You got a B");
        }
        else if (percentage >= 70)
        {
            Console.WriteLine("You got a C");
        }
        else if (percentage >= 60)
        {
            Console.WriteLine("You got a D");
        }
        else
        {
            Console.WriteLine("You got an F");
        }
    }
}