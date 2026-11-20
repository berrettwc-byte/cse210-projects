using System;

class Program
{
    static void Main(string[] args)
    {
        Goals goals = new Goals();
        string choice = "";

        while (choice != "6")
        {
            Console.WriteLine();
            goals.DisplayScore();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1": goals.AddGoal(); break;
                case "2": goals.DisplayGoals(); break;
                case "3": goals.SaveGoals(); break;
                case "4": goals.LoadGoals(); break;
                case "5": goals.RecordEvent(); break;
                case "6": Console.WriteLine("Goodbye!"); break;
                default: Console.WriteLine("Please choose 1-6."); break;
            }
        }
    }
}
