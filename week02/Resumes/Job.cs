public class Job
{
    public string _jobTitle;
    public string _company;
    public string _startTime;
    public string _endTime;
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startTime}-{_endTime}");
    }
}