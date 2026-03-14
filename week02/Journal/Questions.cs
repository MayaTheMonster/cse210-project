using System.ComponentModel.Design;
using System.IO.Enumeration;
using System.IO;
using System.Runtime.InteropServices;
public class Questions
{
    public List<string> questions = new List<string>{"What was the best part of your day?", 
        "What was the most meaningful interaction you had today?", 
        "If you could experience one part of your day again, which part would it be?",
        "If you could redo some part of your day or fix a mistake, what would it be?",
        "If you could change one thing outside of your control, what would have made today better?"};

    
    private Random randomGenerator = new Random();
    public string GenerateRandomQuestion()
    {
        int length = questions.Count;
        int questionNumber = randomGenerator.Next(0,length);
        return questions[questionNumber];
    }

    public void AddQuestion(string question)
    {
        questions.Add(question);
    }

    public void SaveQuestions(string fileName)
    {
        int length = questions.Count;
        if (length != 5)
        {
            using (StreamWriter outputFile = new StreamWriter(fileName, true))
            {
                for (int i = 5; i<length; i++)
                {
                    outputFile.Write("&");
                    outputFile.WriteLine(questions[i]);
                }
            }
        }
    }

    public void LoadQuestions(string fileNameLoad)
    {
        string[] lines = System.IO.File.ReadAllLines(fileNameLoad);

        foreach(string line in lines)
        {
            if (line.Contains("&"))
            {
                string[] cutLine = line.Split("&");
                
                questions.Add(cutLine[1]);
                string what = cutLine[1];
            }
        }
    }

}