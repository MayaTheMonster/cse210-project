using System.ComponentModel;

public abstract class Quest
{
    protected int _questValue;
    protected string _questName;
    protected string _questDescription;
    protected bool _isCompleted;
    
    public virtual void CreateGoalEndpoint()
    {
        _isCompleted = false;
        Console.Write("What shall be the name of the goal? ");
        _questName = Console.ReadLine();
        Console.Write("Give it a short description\n> ");
        _questDescription = Console.ReadLine();
        Console.Write("How many points do you think this goal is worth? ");
        _questValue = int.Parse(Console.ReadLine());
        if(_questValue < 0)
        {
            _questValue = _questValue*-1;
        }
        Console.WriteLine("Creating quest");
        DotsAnimation();
    }
    public abstract string SaveData();
    public abstract void LoadData(List<string> info);
    protected void DotsAnimation()
    {
        for(int i = 0; i < 3; i++)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }
    }
    public abstract int CompleteQuest();
    public virtual void IsComplete()
    {
        string mark = "";
        if (_isCompleted == false)
        {
            mark = " ";
        }
        else
        {
            mark = "X";
        }
        Console.Write($"[{mark}]");
    }
    public virtual void DisplayQuest(int iteration)
    {
        Console.Write($" {iteration}. ");
        IsComplete();
        Console.WriteLine($" {_questName} ({_questDescription})");
    }
    
}