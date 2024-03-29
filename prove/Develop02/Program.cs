using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Transactions;
namespace JournalApp;

class Program
{
    //Journal project
    static void Main(string[] args)
    {
        int select = 6;
        Journal j = new Journal();
        do
        {
            select = getAction();
            if (select == 1)
            {
                j.AddEntry(); // add entry to current journal
            }
            else if (select == 2)
            {
                j.Display(); //display jornal
            }
            else if (select == 4)
            {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine();
                j.Load(filename);
            }
            else if (select == 3)
            {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine();
                j.Save(filename);
            }
            else
            {
                Console.WriteLine("Invalid entry");
            }
        } while (select != 5);
    }

    static int getAction()
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
