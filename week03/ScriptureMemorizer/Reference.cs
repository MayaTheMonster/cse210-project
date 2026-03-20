using System.Collections.Concurrent;

public class Reference
{
    private string _book;
    private string _verse1;
    private string _verse2;
    private string _verse3;
    private string _chapter1;
    private string _chapter2;
    private string _chapter3;
    public Reference(string book,string chapter1,string scripture)
    {
        _book = $"{book}:";
        _verse1 = scripture;
        _verse2 = "";
        _verse3 = "";
        _chapter1 = chapter1;
        _chapter2 = "";
        _chapter3 = "";
    }

    public Reference(string book,string chapter1,string scripture1,string chapter2,string scripture2)
    {
        _book = $"{book}:";
        _verse1 = scripture1;
        _verse2 = scripture2;
        _verse3 = "";
        _chapter1 = chapter1;
        _chapter2 = $"-{chapter2}";
        _chapter3 = "";
    }    
    public Reference(string book,string chapter1,string scripture1,string chapter2,string scripture2,string chapter3,string scripture3)
    {
        _book = $"{book}:";
        _verse1 = scripture1;
        _verse2 = scripture2;
        _verse3 = scripture3;
        _chapter1 = chapter1;
        _chapter2 = "";
        _chapter3 = $"-{chapter3}";
    }


    public void DisplayReference()
    {
        Console.Write($"{_book}{_chapter1}{_chapter2}{_chapter3} ");
    }
}