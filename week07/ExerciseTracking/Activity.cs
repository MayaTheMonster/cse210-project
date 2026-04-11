using System.Diagnostics.CodeAnalysis;

public abstract class Activity
{
    protected double _time;
    protected abstract double GetDistance();
    protected abstract double GetSpeed();
    protected abstract double GetPace();
    protected abstract string GetType();
    public void GetSummary()
    {
        DateTime rightNow = DateTime.Now;
        string dayAndYear = rightNow.ToString("dd MMM yyyy");
        Console.Write(dayAndYear);
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();
        string type = GetType();
        Console.WriteLine($" {type} ({_time} min): Distance {distance} Km, Speed: {speed} kpm, Pace: {pace} min per km");
    }
    public Activity(double time)
    {
        _time = time;
    }
}