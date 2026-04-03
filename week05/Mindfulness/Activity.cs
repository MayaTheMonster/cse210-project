public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    protected void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}\n\n{_description}\n");
        Console.WriteLine("How long, in seconds, would you like your session?");
        string strDuration = Console.ReadLine();
        _duration = int.Parse(strDuration);
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine();
    }
    protected void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(5);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        ShowSpinner(6);
    }
    protected void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string>();
        spinner.Add("==");
        spinner.Add("\\\\");
        spinner.Add("||");
        spinner.Add("//");
        int index = 0;
        while (seconds > 0)
        {
            Console.Write(spinner[index]);
            Thread.Sleep(500);
            Console.Write("\b\b  \b\b");
            index +=1;
            index = SmallReset(index);
            Console.Write(spinner[index]);
            Thread.Sleep(500);
            Console.Write("\b\b  \b\b");
            index +=1;
            index = SmallReset(index);
            seconds -= 1;
        }
        
    }
    private int SmallReset(int resetValue)
    {
        if (resetValue >= 4)
        {
            resetValue = 0;
        }
        return resetValue;
    }
    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}