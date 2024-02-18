using System;
using System.Xml.Serialization;

class Program
{
    private int selection;
    private string SripRef;

    Scripture choice = new Scripture();
    Reference thisone = new Reference();

    static void Main(string[] args)
    {
        /*
            giveOptions();
            GiveScripture();
            printReference(SripRef);
            printScripture();
        */
    }

    static int giveOptions()
    {
        Console.WriteLine("Please Select the Scripture you would like to practice");
        Console.WriteLine("1-- 1st Nephi 3:7");
        Console.WriteLine("2-- D&C 8: 2-3");
        return (int.Parse(Console.ReadLine()));
    }

    void GiveScripture()
    {
        SripRef = thisone.getReference(selection);


    }

    void printReference(string Ref)
    {
        Console.WriteLine($"<{Ref}>");

    }

    void printScripture()
    {

    }

}