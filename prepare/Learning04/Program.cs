using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        mathAssignment math1 = new mathAssignment("Bob", "numbers", "Section 2.1", "1-21");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());
        writingAssignment writing1 = new writingAssignment("Bob", "numbers", "the orgin of numbers");
        Console.WriteLine(writing1.GetWritingInfo());
    }
}