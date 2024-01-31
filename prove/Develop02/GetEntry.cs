namespace JournalApp;
class GetEntry
{

    public List<string> prompts = new List<string>();

    public string get()
    {
        Random rnd = new Random();
        int thisOne = rnd.Next(5);
        prompts.Add("What was the best thing that you did today?");
        prompts.Add("What goals did you work towards today?");
        prompts.Add("What would you do exactly the same if you were to relive today?");
        prompts.Add("What is one thing that you learned today?");
        prompts.Add("Write song lyrics to describe your day.");
        Console.WriteLine(prompts[thisOne]);
        return (Console.ReadLine());
    }
}