using System;
using System.Reflection.Metadata;

class Program
{
    // static double AddNumbers(double x, int y)
    // {
    //     return x + y;    
    // }

    // static string MyName()
    // {
    //     return "Bob";
    // }

    // static void DisplayGreeting(string name)
    // {
    //     Console.WriteLine($"Welcome {name}, it's nice to meet you.");
    // }
    static void Main(string[] args)
    {
        Circle myCircle = new Circle();

        myCircle._radius = 10;

        double area = myCircle.GetArea();

        Console.WriteLine(area);
    }
}














        // string myName = MyName();
        // DisplayGreeting(myName);
        // double total = AddNumbers(12.234, 20);
        // Console.WriteLine(total);




        // int x = 10;
        // int y = 30;
        // int z = 40;

        // if (x == 10 && y == 30 || z == 30) /* && is and || is or */
        // {
        //     Console.WriteLine("X is 10!");
        //     Console.WriteLine("Y is fun!");
        // }
        // else if (x == 20)
        // {
        //     Console.WriteLine("X is 20");
        // }
        // else
        // {
        //     Console.WriteLine("Default output");
        // }




        // bool done = false;

        // while (!done)
        // {
        //     Console.Write("Are we done yet (y/n)? ");
        //     done = Console.ReadLine() == "y";
        // }




        // bool done = false;

        // do
        // {
        //     Console.Write("Are we done yet (y/n)? ");
        //     done = Console.ReadLine().ToLower() == "y";
        // }while (!done);



        
        // for(int i = 100; i >= -50; i -= 10)
        // {
        //     Console.WriteLine(i);
        // }




        // List<string> myFriends = new List<string>("Bob", "Betty", "Bubba");

        // myFriends.Add("doug");

        // foreach(string friend in myFriends)
        // {
        //     Console.WriteLine(friend);
        // }