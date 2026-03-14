public class Page
{       
    public string _question;
    public string _entry;
    public string _time;

    public void DisplayQuestionEntry()
    {
        Console.WriteLine();
        Console.WriteLine($"Date:{_time} - Prompt:{_question}");
        Console.WriteLine(_entry);
        Console.WriteLine();
    }
}