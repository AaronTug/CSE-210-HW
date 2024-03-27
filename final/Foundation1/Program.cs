using System;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Test1", "Dude", 171);
        video1.makecomment("first comment", "Mr");
        video1.makecomment("second comment", "Ms");
        video1.makecomment("are we just counting comments?", "Dad");
        video1.display();
        Video video2 = new Video("Test2", "Guy", 76);
        video2.makecomment("pinin this comment", "Guy");
        video2.makecomment("love this", "lover");
        video2.makecomment("hate this", "hater");
        video2.display();
        Video video3 = new Video("Test3", "Man", 411);
        video3.makecomment("why is this on my recomended?", "google spy");
        video3.makecomment("can i join?", "social guy");
        video3.makecomment("why is this a thing?", "philosopher");
        video3.display();

        //Console.WriteLine("Hello Foundation1 World!");
    }
}