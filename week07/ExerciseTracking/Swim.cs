public class Swim : Activity
{
    private double _laps;
    public Swim(double time, double laps) : base(time)
    {
        _laps = laps;
    }
    protected override double GetDistance()
    {
        return _laps*50/1000;
    }
    protected override double GetSpeed()
    {
        return ((_laps*50/1000)/_time)*60;
    }
    protected override double GetPace()
    {
        return 60/((_laps*50/1000)/_time*60);
    }
    protected override string GetType()
    {
        return "Swimming";
    }
}