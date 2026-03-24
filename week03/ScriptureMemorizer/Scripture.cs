using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

public class Scripture
{
    private string _scripture;
    private int _wordsDeleted;
    private int _trueCount;
    public List<string> SetScripture()
    {
        Console.Write("Please insert how many consecultive scriptures you wish to memorize up to 3 (ex:1): ");
        string stringAmmount = Console.ReadLine();
        int intAmmount = int.Parse(stringAmmount);
        if (intAmmount>3 || intAmmount <= 0)
        {
            intAmmount = 1;
        }
        string noun = "is the scripture";
        if (intAmmount > 1)
        {
            noun = "are the scriptures";
        }
        Console.WriteLine($"what chapter {noun} you are trying to memorize from?");
        string chapter = Console.ReadLine();
        List<string> groupedScriptures = new List<string>();
        groupedScriptures.Add(stringAmmount);
        groupedScriptures.Add(chapter);
        List<string> groupedScriptures2 = AskVerseSCripture(intAmmount);
        groupedScriptures.AddRange(groupedScriptures2);
        ActuallyAddScriptures(groupedScriptures);

        return groupedScriptures;
    }

    private List<string> AskVerseSCripture(int count)
    {
        List<string> temporary = new List<string>(); 
        while (count > 0)
        {
            Console.Write("Please insert the verse number your scripture is from (ex:12): ");
            string key = Console.ReadLine();
            Console.WriteLine("Please insert the scripture you are trying to memorize");
            string value = Console.ReadLine();
            
            temporary.Add(key);
            temporary.Add(value);
            count -= 1;
        }
        return temporary;
    }

    private void ActuallyAddScriptures(List<string> groupedScriptures)
    {
        string megaText = "";
        int length = groupedScriptures.Count();
        for(int i=3; i<=length-1; i+=2)
        {
            string text = groupedScriptures[i];
            megaText += $"{text} ";
        }
        _scripture = megaText;
        countScripture();
    }
    public void DisplayCurrentScriptures()
    {
        Console.WriteLine(_scripture);
    }

    public string HideWords()
    {
        Word hider = new Word();
        string newScripture = hider.HideWord(_scripture,_wordsDeleted,_trueCount);
        _wordsDeleted = hider.GetWordsDeleted();
        string displayMessage = hider.GetDetector();
        _scripture = newScripture;
        return displayMessage;
    }

    public void ResetScriptureHider(List<string> origin)
    {
        ActuallyAddScriptures(origin);
        ScriptureCountResetter();
    }
    public void ScriptureCountResetter()
    {
        _wordsDeleted = 0;
    }

    private void countScripture()
    {
        List<string> scriptureList = _scripture.Split().ToList();
        _trueCount = scriptureList.Count();
    }
}