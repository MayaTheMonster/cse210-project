public class NamingActivity : Activity
{
    private int _count;
    public NamingActivity()
    {
        _name = "Naming Activity";
        _description = "This activity will help you calm down by naming as many things or names starting with a randomly selected letter.";
    }
    private List<string> _alphabet = new List<string>{"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
    private Random _getRandomThingy = new Random();
    public void RunNamingActivity()
    {
        DisplayStartingMessage();
        string prompt = GetRandomLetter();
        Console.WriteLine($"List as many words as you can that start with the following letter:\n ---{prompt}---\n");
        Console.Write("You may begin in:");
        ShowCountDown(5);
        GetListFromUser();
        DisplayEndingMessage();
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
        Console.WriteLine($"You have listed {_count} words!\n");
    }
    private string GetRandomLetter()
    {
        int randomQuestion = _getRandomThingy.Next(0, _alphabet.Count);
        return _alphabet[randomQuestion];
    }
}