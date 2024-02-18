using System.ComponentModel;
using JournalApp;
using Microsoft.VisualBasic;

public class Journal
{
    public List<Entry> entrys;

    public void AddEntry()
    {
        Entry E = new Entry();
        E.get();
        entrys.Add(E);


    }

    public void Display()
    {
        foreach (var entry in entrys)
        {
            Console.WriteLine(entry.DisplayEntry);
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