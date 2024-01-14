using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string wordGrade = Console.ReadLine();
        int grade = int.Parse(wordGrade);
        string letter;
        if (grade < 60)
        {
            letter = "F";
        }
        else if (grade >= 80)
        {
            if (grade >= 90)
            {
                letter = "A";
            }
            else
            {
                letter = "B";
            }
        }
        else
        {
            if (grade >= 70)
            {
                letter = "C";
            }
            else
            {
                letter = "D";
            }
        }
        Console.WriteLine($"Your letter grade is {letter}");
        if (grade >= 70)
        {
            Console.WriteLine("Congradulations! You passed!");
        }
        else
        {
            Console.WriteLine("Try again.");
        }

    }
}