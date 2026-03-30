using System.Security.Cryptography;

public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studer, string tropic)
    {
        _studentName = studer;
        _topic = tropic;
    }

    protected string GetSummary()
    {
        string majorString = $"{_studentName} - {_topic}";
        return majorString;
    }
}