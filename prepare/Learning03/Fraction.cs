class Fraction
{
    private int top;
    private int bottom;

    //constructors
    public Fraction()
    {
        top = 1;
        bottom = 1;
    }

    public Fraction(int TempTop)
    {
        top = TempTop;
        bottom = 1;
    }
    public Fraction(int TempTop, int TempBottom)
    {
        top = TempTop;
        bottom = TempBottom;
    }

    //getters
    public int GetTop()
    {
        return (top);
    }

    public int GetBottom()
    {
        return (bottom);
    }

    //setters
    public void SetTop(int temp)
    {
        top = temp;
    }

    public void SetBottom(int temp)
    {
        bottom = temp;
    }

    //
    public string GetFraction()
    {
        return ($"{top}/{bottom}");
    }
    public double Getdecimal()
    {
        double DTop = (double)top;
        double DBottom = (double)bottom;
        return (DTop / DBottom);
    }



}