using System.Security.Cryptography;
using System.Transactions;

class Video
{
    private string title;
    private string author;
    private int legnth;
    private List<Comment> comments = new List<Comment>();

    public Video(string Title, string Author, int Legnth)
    {
        this.title = Title;
        this.author = Author;
        this.legnth = Legnth;

    }
    public void makecomment(string Text, string Author)
    {
        Comment c1 = new Comment(Text, Author);
        comments.Add(c1);
    }

    public void display()
    {
        Console.WriteLine($"{title}, {author}, {legnth}, # of comments: {comments.Count}");
        foreach (var comment in comments)
        {
            comment.display();
        }
    }

}