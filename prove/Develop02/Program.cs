using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Transactions;
namespace JournalApp;

class Program
//Journal project
{
    public string curent = "";
    static void Main(string[] args)
    {
        // GetEntry G = new GetEntry();
        //G.get();
        Program p = new Program();
        //Console.WriteLine("Hello Develop02 World!");
        //Console.Clear();
        p.showMenu();
    }

    int showMenu()
    {
        Console.WriteLine(@"Please select an option
        1. New entry
        2. Display Journal
        3. Save to file
        4. Load file
        5. Quit program");
        int responce = int.Parse(Console.ReadLine());
        return (responce);

    }


}
