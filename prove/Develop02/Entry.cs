namespace JournalApp;
public class Entry
{
    private string prompt;
    private string date;
    private string responce;



    public List<string> prompts = new List<string>();

    public void get()
    {
        DateTime Temp = DateTime.Now;
        Random rnd = new Random();
        prompts.Add("What was the best thing that you did today?");
        prompts.Add("What goals did you work towards today?");
        prompts.Add("What would you do exactly the same if you were to relive today?");
        prompts.Add("What is one thing that you learned today?");
        prompts.Add("Write song lyrics to describe your day.");
        int thisOne = rnd.Next(prompts.Count);
        Console.WriteLine(prompts[thisOne]);
        this.date = Temp.ToShortDateString();
        this.prompt = prompts[thisOne];
        this.responce = Console.ReadLine();
    }

    public string DisplayEntry()
    {
        return $"{this.date}: {this.prompt}: {this.responce}:";
    }
}