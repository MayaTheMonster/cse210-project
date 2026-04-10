public class StoryQuest : Quest
{
    public override string SaveData()
    {
        string major = $"Story|{_questName}|{_questDescription}|{_questValue}|{_isCompleted}";
        
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
    }
    public override int CompleteQuest()
    {
        if (_isCompleted == true)
        {
            Console.WriteLine("This quest already has been completed.");
            return 0;
        }
        else
        {
            _isCompleted = true;
            return _questValue;
        }
        
    }
}