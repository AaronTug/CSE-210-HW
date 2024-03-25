class Comment
{
    private string author;
    private string text;
    public Comment(string T, string A)
    {
        this.text = T;
        this.author = A;
    }

    public void display()
    {
        Console.WriteLine($"{text}, {author}");
    }


}