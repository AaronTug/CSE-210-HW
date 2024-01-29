using System;
using System.Runtime.CompilerServices;
namespace JournalApp;

class Program
//Journal project
{
    static void Main(string[] args)
    {
        Program p = new Program();
        Console.WriteLine("Hello Develop02 World!");
        Console.Clear();
        p.showMenu();

    }

    int showMenu()
    {
        int responce = int.Parse(Console.ReadLine());
        return (responce);

    }


}
