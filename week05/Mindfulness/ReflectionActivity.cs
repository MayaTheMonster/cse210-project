using System.Runtime.CompilerServices;

public class ReflectionActivity : Activity
{
    public ReflectionActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area";
    }
    private Random _getRandomThingy = new Random();
    public void RunReflection()
    {
        DisplayStartingMessage();
        string prompt = GetRandomQuestion();
        Console.WriteLine($"Consider the following prompt:\n\n --- {prompt} ---\n\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Write("\nNow ponder on each of the following questions as they related to this experience.\nYou may begin in: ");
        ShowCountDown(5);
        Console.Clear();
        ShowRandomPrompt();
        DisplayEndingMessage();
    }
    
    private string GetRandomQuestion()
    {
        List<string> question = new List<string>{"Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."};
        int randomQuestion = _getRandomThingy.Next(0, question.Count);
        return question[randomQuestion];
    }
    private void ShowRandomPrompt()
    {
        List<string> question = new List<string>{"Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?",
        "How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"};
        int randomQuestion = _getRandomThingy.Next(0, question.Count);
        Console.WriteLine(question[randomQuestion]);
        ShowSpinner(15);
        int runtime = 15;
        while (runtime < _duration)
        {
            if (question.Count == 0)
            {
                break;
            }
            question.RemoveAt(randomQuestion);
            randomQuestion = _getRandomThingy.Next(0, question.Count);
            Console.WriteLine(question[randomQuestion]);
            ShowSpinner(15);
            runtime +=15;
        }
        Console.WriteLine();
    }
}