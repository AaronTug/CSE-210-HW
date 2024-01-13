using System;

class Program
{
    static void Main(string[] args)
    {
        //define variables
        string first;
        string last;
        //ask for and get information
        Console.Write("What is your first name? ");
        first = Console.ReadLine();
        Console.Write("What is your last name? ");
        last = Console.ReadLine();
        //display results
        Console.WriteLine($"Your name is {last}, {first} {last}.");

    }
}