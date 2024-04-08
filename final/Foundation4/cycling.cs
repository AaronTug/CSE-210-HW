class Cycling : Activity
{
    private float speed;
    public Cycling(String dat, float sp, int t)
    {
        this.speed = sp;
        this.time = t;
        this.date = dat;
    }
    public override double getdistance()
    {
        return ((speed / time) / 60);
    }
    public override double getspeed()
    {
        return (speed);

    }
    public override double getpace()
    {
        float temp = (60 / speed);
        return (temp);
    }
    public override string getsummary()
    {
        return ($"({date} Running ({time} min)- Distance: {getdistance()}miles, Speed: {getspeed()}mph, Pace: {getpace()}min per mile");

    }
}