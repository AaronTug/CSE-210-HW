using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture EventL = new Lecture("stagelecture", "this is a stage lecture", "3/3/3", "3:33", "stage", "stage speaker", 333);
        Reception EventR = new Reception("reception", "this is a reception", "4/4/4", "4:44", "reception place", "thisemail.org");
        Outdoor EventO = new Outdoor("Park playtime", "this is a park playtime", "5/5/5", "5:55", "park", "cloudy");
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine(EventL.GetDetails(i));
            Console.WriteLine(EventR.GetDetails(i));
            Console.WriteLine(EventO.GetDetails(i));


        }
        //Console.WriteLine("Hello Foundation3 World!");
    }
}