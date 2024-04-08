using System.Diagnostics;
using System.Runtime.CompilerServices;

class Running : Activity
{
    private double distance;
    public Running(String dat, double Dist, int t)
    {
        this.distance = Dist;
        this.time = t;
        this.date = dat;

    }
    public override double getdistance()
    {
        return (distance);
    }
    public override double getspeed()
    {
        double temp = (distance / time);
        return (temp);

    }
    public override double getpace()
    {
        double temp = (time / distance);
        return (temp);
    }
    public override string getsummary()
    {
        return ($"({date} Running ({time} min)- Distance: {getdistance()}miles, Speed: {getspeed()}mph, Pace: {getpace()}min per mile");

    }
}