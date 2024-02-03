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
        string current = " ";
        Program p = new Program();
        int select = p.showMenu();
        Console.Clear();
        do
        {
            if (select == 1)
            {
                GetEntry G = new GetEntry();
                current = current + G.get();
            }
            else if (select == 2)
            {

            }
            else if (select == 3)
            {

            }
            else if (select == 4)
            {
                Console.WriteLine(current);

            }
            select = p.showMenu();
        } while (select != 5);
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
