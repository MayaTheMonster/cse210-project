public class RepeatQuest : Quest
{
    private int _timesCompleted;
    public RepeatQuest()
    {
        _questValue = 0;
        _questName = "";
        _questDescription = "";
        _isCompleted = false;
        _timesCompleted = 0;
    }
    public override void IsComplete()
    {
        Console.Write($"[{_timesCompleted}]");
    }
    public override string SaveData()
    {
        string major = $"Repeat|{_questName}|{_questDescription}|{_questValue}|false|{_timesCompleted}";
        
        return major;
    }
    public override void LoadData(List<string> info)
    {
        _questName = info[1];
        _questDescription = info[2];
        _questValue = int.Parse(info[3]);
        _isCompleted = false;
        _timesCompleted = int.Parse(info[5]);
    }
    public override int CompleteQuest()
    {
        _timesCompleted += 1;
        return _questValue;
    }
}