using System;

class Program
{
    static void Main(string[] args)
    {
        Running run = new Running("3/3/3", 10, 60);
        Cycling bike = new Cycling("4/4/4", 15, 30);
        Swimming swim = new Swimming("5/5/5", 200, 45);
        Console.WriteLine($"{run.getsummary()}");
        Console.WriteLine($"{bike.getsummary()}");
        Console.WriteLine($"{swim.getsummary()}");
        //Console.WriteLine("Hello Foundation4 World!");
    }
}