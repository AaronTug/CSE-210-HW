using System;

class Program
{
    static void Main(string[] args)
    {
        //using constructors
        Fraction f = new Fraction();
        //Console.WriteLine(f.GetFraction());
        Fraction g = new Fraction(5);
        //Console.WriteLine(g.GetFraction());
        Fraction h = new Fraction(3, 4);
        // Console.WriteLine(h.GetFraction());

        //using getters and setters
        /*        f.SetTop(4);
                f.SetBottom(9);
                Console.WriteLine(f.GetTop());
                Console.WriteLine(f.GetBottom());
        */
        //retruning representations
        Console.WriteLine(f.GetFraction());
        Console.WriteLine(f.Getdecimal());
        Console.WriteLine(g.GetFraction());
        Console.WriteLine(g.Getdecimal());
        Console.WriteLine(h.GetFraction());
        Console.WriteLine(h.Getdecimal());
        Fraction j = new Fraction(1, 3);
        Console.WriteLine(j.GetFraction());
        Console.WriteLine(j.Getdecimal());



    }
}