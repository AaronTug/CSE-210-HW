using System.ComponentModel;
using System.Runtime.CompilerServices;
using JournalApp;
using Microsoft.VisualBasic;

public class Journal
{
    public List<Entry> entrys;
    public Journal()
    {
        entrys = new List<Entry>();
    }
    public List<string> prompts = new List<string>();

    public void AddEntry()
    {
        DateTime Temp = DateTime.Now;
        string Time = Temp.ToShortDateString();
        Random rnd = new Random();
        prompts.Add("What was the best thing that you did today?");
        prompts.Add("What goals did you work towards today?");
        prompts.Add("What would you do exactly the same if you were to relive today?");
        prompts.Add("What is one thing that you learned today?");
        prompts.Add("Write song lyrics to describe your day.");
        int thisOne = rnd.Next(prompts.Count);
        string towrite;
        towrite = prompts[thisOne];
        Console.WriteLine(towrite);
        string Resp = Console.ReadLine();
        Entry entry = new Entry(Time, towrite, Resp);
        entrys.Add(entry);
    }

    public void Display()
    {
        foreach (var entry in entrys)
        {
            string temp = entry.DisplayEntry();
            Console.WriteLine(temp);
        }
    }

    /* public Journal Load()
     {
         return ();
     }
 */
    public void Save()
    {

    }

}