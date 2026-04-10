public class EliteQuest : Quest
{
    private int _timesCompleted;
    private int _repeatValue;
    private int _bonusValue;
    public EliteQuest()
    {
        _questValue = 0;
        _questName = "";
        _questDescription = "";
        _isCompleted = false;
        _timesCompleted = 0;
        _repeatValue = 0;
        _bonusValue = 0;
    }
    public override void CreateGoalEndpoint()
    {
        _isCompleted = false;
        Console.Write("What shall be the name of the goal? ");
        _questName = Console.ReadLine();
        Console.Write("Give it a short description\n> ");
        _questDescription = Console.ReadLine();
        Console.Write("How many points do you think one of this goal is worth? ");
        _questValue = int.Parse(Console.ReadLine());
        if(_questValue < 0)
        {
            _questValue = _questValue*-1;
        }
        Console.Write("How many times does this quest need to be repeated? " );
        _repeatValue = int.Parse(Console.ReadLine());
        _bonusValue = _questValue*_repeatValue;
        Console.WriteLine("Creating quest");
        DotsAnimation();
    }
    public override void DisplayQuest(int iteration)
    {
        Console.Write($" {iteration}. ");
        IsComplete();
        Console.WriteLine($" {_questName} ({_questDescription}) -- Completed: {_timesCompleted}/{_repeatValue}");
    }
    public override string SaveData()
    {
        string major = $"Elite|{_questName}|{_questDescription}|{_questValue}|{_isCompleted}|{_bonusValue}|{_timesCompleted}|{_repeatValue}";
        
        return major;
    }
    public override void LoadData(List<string> info)
    {
        _questName = info[1];
        _questDescription = info[2];
        _questValue = int.Parse(info[3]);
        if (info[4] == "true")
        {
            _isCompleted = true;
        }
        else
        {
            _isCompleted = false;
        }
        _bonusValue = int.Parse(info[5]);
        _timesCompleted = int.Parse(info[6]);
        _repeatValue = int.Parse(info[7]);
    }
    public override int CompleteQuest()
    {
        _timesCompleted += 1;
        if (_isCompleted == true)
        {
            Console.WriteLine("This quest already has been completed.");
            _timesCompleted = _repeatValue;
            return 0;
        }
        else if (_isCompleted == false && _timesCompleted == _repeatValue)
        {
            int total = _questValue+_bonusValue;
            return total;
        }
        else
        {
            return _questValue;
        }
    }
}