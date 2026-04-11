public class Bycicle : Activity
{
    private double _speed;
    public Bycicle(int time, double speed) : base(time)
    {
        _speed = speed;
    }
    protected override double GetDistance()
    {
        return _time*_speed;
    }

    protected override double GetSpeed()
    {
        return _speed;
    }
    protected override double GetPace()
    {
        return 60/_speed;
    }
    protected override string GetType()
    {
        return "Cycling";
    }
}