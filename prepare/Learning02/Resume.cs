using System;

public class Resume
{
    public string _name;
    public List<Job> _info = new List<Job>();
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}\nJobs:");

        foreach (Job i in _info)
        {
            i.Display();
        }

    }
}
