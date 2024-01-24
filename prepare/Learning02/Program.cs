using System;

class Program
{
    static void Main(string[] args)
    {
        Resume p = new Resume();
        Job job1 = new Job();
        job1._jobTitle = "artist";
        job1._company = "Disney";
        job1._startYear = 1999;
        job1._endYear = 2000;
        Job job2 = new Job();
        job2._jobTitle = "engineer";
        job2._company = "Mine";
        job2._startYear = 1997;
        job2._endYear = 1998;
        Resume mine = new Resume();
        mine._name = "Aaron Tuggle";
        mine._info.Add(job1);
        mine._info.Add(job2);
        mine.DisplayResume();

    }
}