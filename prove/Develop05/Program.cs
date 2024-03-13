using System;

class Program
{
    static int tpoints = 0;
    static public List<GoalS> G;
    static void Main(string[] args)
    {

        G = new List<GoalS>();
        //Console.WriteLine("Hello Develop05 World!");
        int choice = 0;
        do
        {
            choice = showmenu();
            switch (choice)
            {
                case 1:

                    break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:

                    break;

                case 5:

                    break;

                case 6:
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        } while (choice != 6);
    }

    static int showmenu()
    {
        Console.WriteLine($"\nYou have " + tpoints + " points.\n\n");

        Console.WriteLine(@"Menu Options
            1. Create New Goal
            2. List Goals
            3. Save Goals
            4. Load Goals
            5. Record Event
            6. Quit");
        return (int.Parse(Console.ReadLine()));
    }
}