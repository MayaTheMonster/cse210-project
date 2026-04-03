public class ListingActivity : Activity
{
    public ListingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have \nand how you can use it in other aspects of your life.";
    }
    private int _count;
    public void RunListingActivity()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine($"List as many responses as you can to the following prompt:\n ---{prompt}---\n");
        Console.Write("You may begin in:");
        ShowCountDown(5);
        GetListFromUser();
        DisplayEndingMessage();
    }
    private Random _getRandomThingy = new Random();
    private string GetRandomPrompt()
    {
        List<string> question = new List<string>{"Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};
        int randomQuestion = _getRandomThingy.Next(0, question.Count);
        return question[randomQuestion];
    }
    private void GetListFromUser()
    {
        _count = 0;
        DateTime startClock = DateTime.Now;
        DateTime endClock = startClock.AddSeconds(_duration);
        while (DateTime.Now < endClock)
        {
            List<string> _usertList = new List<string>();
            Console.Write(">");
            string userText = Console.ReadLine();
            _usertList.Add(userText);
            _count +=1;
        }
        Console.WriteLine($"You have listed {_count} items!\n");
    }
}