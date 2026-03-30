public class MathAssignment : Assignment
{
    public MathAssignment(string name, string topic, string textSection, string problem) : base(name, topic)
    {
        _textbookSection = textSection;
        _problems = problem;
    }
    private string _textbookSection;
    private string _problems;
    public string GetHomeworkList()
    {
        string formattedString1 = GetSummary();
        string formattedString2 = $"{formattedString1}\nSection {_textbookSection} Problems {_problems}";
        return formattedString2;
    }
}