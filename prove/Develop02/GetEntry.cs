namespace JournalApp;
class GetEntry
{

    public List<string> prompts = new List<string>();
    public string date;

    public string get()
    {
        date = "";//placeholder
        Random rnd = new Random();
        prompts.Add("What was the best thing that you did today?");
        prompts.Add("What goals did you work towards today?");
        prompts.Add("What would you do exactly the same if you were to relive today?");
        prompts.Add("What is one thing that you learned today?");
        prompts.Add("Write song lyrics to describe your day.");
        int thisOne = rnd.Next(prompts.Count);
        Console.WriteLine(prompts[thisOne]);
        return (date + prompts[thisOne] + Console.ReadLine());
    }
}