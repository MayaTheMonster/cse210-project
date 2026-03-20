using System.Security.Cryptography;

public class Word
{
    //Scripture reader = new Scripture();
    public string HideWord(string listString)
    {
        List<string>wordList = listString.Split().ToList();
        int listLong = wordList.Count();
        Random NumberGenerator = new Random();
        int NumberOfWords = NumberGenerator.Next(2,4);

        while (NumberOfWords>=1)
        {
            int RandomWord = NumberGenerator.Next(0,listLong-1);
            string chosenWord = wordList[RandomWord];
            int wordLenght = chosenWord.Length;
            char annoying = '_';
            bool valor = chosenWord.Contains(annoying);
            if (chosenWord == "")
            {
                valor = true;
            }
            if (valor == false)
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