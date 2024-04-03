using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture EventL = new Lecture();
        Reception EventR = new Reception();
        Outdoor EventO = new Outdoor();
        for (int i = 1; i > 3; i++)
        {
            Console.WriteLine(EventL.GetDetails(i));
            Console.WriteLine(EventR.GetDetails(i));
            Console.WriteLine(EventO.GetDetails(i));


        }
        //Console.WriteLine("Hello Foundation3 World!");
    }
}