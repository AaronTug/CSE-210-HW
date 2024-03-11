namespace JournalApp;
public class Entry
{
    public string prompt;
    public string date;
    public string responce;

    public Entry(string Date, string prompt1, string resp)
    {
        this.date = Date;
        this.prompt = prompt1;
        this.responce = resp;


    }

    public string DisplayEntry()
    {
        return $"{this.date}: {this.prompt}: {this.responce}:";
    }
}