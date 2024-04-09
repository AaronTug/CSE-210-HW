class Swimming : Activity
{
    private double laps;
    public Swimming(String dat, double Dist, int t)
    {
        this.laps = Dist;
        this.time = t;
        this.date = dat;
    }
    public override double getdistance()
    {
        double temp = (laps * (50.0 / 1000.0));
        return (temp);
    }
    public override double getspeed()
    {
        double temp = ((laps * (50.0 / 1000.0)) / time);
        return (temp);

    }
    public override double getpace()
    {
        double temp = (time / (laps * (50.0 / 1000.0)));
        return (temp);
    }
    public override string getsummary()
    {
        string temp = ($"({date} Swiming ({time} min)- Distance: {getdistance()}miles, Speed: {getspeed()}mph, Pace: {getpace()}min per mile");
        return ($"({temp}");

    }
}