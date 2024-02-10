namespace JournalApp;
using System.IO;


class Files
{
    public string filename;
    public string current;
    List<string> filearray = new List<string>();
    public string Load()
    {
        Console.Write("What is the name of the file? ");
        filename = Console.ReadLine();
        string[] filearray = System.IO.File.ReadAllLines(filename);
        string returnthis = "";
        foreach (string line in filearray)
        {
            string[] part = line.Split("<>");
            returnthis = part[0];

        }
        return (returnthis);

    }

    public void Save(string saveThis)
    {
        Console.Write("What is the name of the file? ");
        filename = Console.ReadLine();
        using (StreamWriter output = new StreamWriter(filename))
        {
            output.Write($"{current}");

        }


    }

}