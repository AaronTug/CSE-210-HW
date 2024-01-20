using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string name;
        int num;
        double square;
        Program p = new Program();
        p.DisplayWelcome();
        name = p.PromtUserName();
        num = p.PromptUserNumber();
        square = p.SquareNumber(num);
        p.DisplayResults(name, square);
    }

    void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    string PromtUserName()
    {
        string name;
        Console.Write("Please enter your name: ");
        name = Console.ReadLine();
        return (name);
    }

    int PromptUserNumber()
    {
        int num;
        Console.Write("Please enter your favorite number: ");
        num = int.Parse(Console.ReadLine());
        return (num);
    }

    double SquareNumber(int num)
    {
        double result = Math.Pow(num, 2);
        return (result);
    }

    void DisplayResults(string name, double square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }
}