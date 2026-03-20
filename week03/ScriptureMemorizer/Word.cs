using System.Security.Cryptography;

public class Word
{
    //Scripture reader = new Scripture();

    private string _word;
    private List<string> _Word = new List<string>();

    public string HideWord(string listString)
    {
        List<string>wordList = listString.Split().ToList();
        int listLong = wordList.Count();
        Random NumberGenerator = new Random();
        int NumberOfWords = NumberGenerator.Next(2,4);

        while (NumberOfWords>=1)
        {
            int RandomWord = NumberGenerator.Next(0,listLong);
            string chosenWord = wordList[RandomWord];
            int wordLenght = chosenWord.Length;
            if (!chosenWord.Contains("_"))
            {
                NumberOfWords-=1;
            }
            string message = "";
            for (int i = 0; i<= wordLenght-1; i++)
            {
                message += "_";
            }
            wordList[RandomWord] = message;
        }
        string updatedString = "";
        foreach (string sentence in wordList)
        {
            updatedString += $"{sentence} "; 
        }
        return updatedString;
    }
}