namespace JournalApp;
public class Entry
{
    private string prompt;
    private string date;
    private string responce;

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