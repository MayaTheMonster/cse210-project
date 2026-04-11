public class Run : Activity
{
    private double _distance;
    public Run(int time, double distance) : base(time)
    {
        _distance = distance;
    }
    protected override double GetDistance()
    {
        return _distance;
    }
    protected override double GetSpeed()
    {
        return _distance/_time*60;
    }
    protected override double GetPace()
    {
        return 60/(_distance/_time*60);
    }
    protected override string GetType()
    {
        return "Running";
    }
}