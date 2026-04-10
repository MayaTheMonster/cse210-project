using System.Threading.Channels;

public class Portal
{
    public List<Quest> _questBoard = new List<Quest>();
    private int _level;
    private int _experience;
    private int _totalExperience;
    public void Start()
    {
        bool execting = true;
        while(execting == true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:\n 1. Create New Quest\n 2. List Quests\n 3. Check Stats\n 4. Remove Quest\n 5. Save Quests");
            Console.WriteLine(" 6. Load Quests\n 7. Report Quest\n 8. Quit\nSelect a choice from the menu: ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                CreateQuest();
            }
            else if (choice == "2")
            {
                ListQuests();
            }
            else if (choice == "3")
            {
                DisplayStats();
            }
            else if (choice == "4")
            {
                RemoveQuest();
            }
            else if (choice == "5")
            {
                SaveList();
            }
            else if (choice == "6")
            {
                LoadList();
            }
            else if(choice == "7")
            {
                CompleteQuest();
            }
            else if (choice == "SHAW")
            {
                CheatEngine(0,0,0);
            }
            else
            {
                execting = false;
            }
        }
    }
    private void CreateQuest()
    {
        Console.Clear();
        Console.WriteLine("The types of goals are:\n 1. Simple Goal\n 2. Repeatable Goal\n 3. Checklist Goal\n 4. Return");
        Console.Write("Which type of goal do you wish to create? ");
        string goal =Console.ReadLine();
        if (goal == "1")
        {
            StoryQuest ice = new StoryQuest();
            ice.CreateGoalEndpoint();
            _questBoard.Add(ice);
        }
        else if (goal == "2")
        {
            RepeatQuest light = new RepeatQuest();
            light.CreateGoalEndpoint();
            _questBoard.Add(light);
        }
        else if (goal == "3")
        {
            EliteQuest magma = new EliteQuest();
            magma.CreateGoalEndpoint();
            _questBoard.Add(magma);
        }
    }
    private void ListQuests()
    {
        Console.Clear();
        Console.WriteLine("Quest Board:");
        int q = 1;
        foreach (Quest quest in _questBoard)
        {
            quest.DisplayQuest(q);
            q += 1;
        }
        Console.Write("Press Enter to continue ");
        Console.ReadLine();
    }
    public void DisplayStats()
    {
        Console.Clear();
        Console.WriteLine();
        int expToNextlevel = 100 + _level*100;
        int levelUp = expToNextlevel - _experience;
        Console.WriteLine("Stats:");
        Console.WriteLine($" Your are currently at level {_level}\n EXP to the next level: {levelUp}");
        Console.WriteLine($" total experience so far: {_totalExperience}");
        Console.WriteLine("\nPress Enter to continue ");
        Console.ReadLine();
    }
    protected void LevelUp()
    {
        int expToNextlevel = 100 + _level*100;
        while (_experience >= expToNextlevel)
        {
            _level += 1;
            _experience -= expToNextlevel;
            expToNextlevel = 100 + _level*100;
            Console.WriteLine($"YOU LEVELED UP TO LEVEL {_level}!");
        }
        Console.Write("Press enter to continue.");
        Console.ReadLine();
    }
    private void CheatEngine(int level, int exp, int totalExp)
    {
        _level = level;
        _experience = exp;
        _totalExperience = totalExp;
    }
    private void RemoveQuest()
    {
        Console.Clear();
        Console.WriteLine("Which quest would you like to remove? Type 0 to cancel.");
        int d = 1;
        foreach (Quest quest in _questBoard)
        {
            quest.DisplayQuest(d);
            d +=1;
        }
        int removal = int.Parse(Console.ReadLine());
        if (removal != 0)
        {
            _questBoard.RemoveAt(removal-1);
            Console.WriteLine($"Deleting Quest {removal}");
            DotsAnimation2();
        }
    }
    private void SaveList()
    {
        Console.Write("What shall be the name of the file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{_level}|{_experience}|{_totalExperience}");
            foreach(Quest quest in _questBoard)
            {
                string data = quest.SaveData();
                outputFile.WriteLine(data);
            }
        }
    }
    private void LoadList()
    {
        Console.Write("Where have you stored your quests? Type QUIT to cancel: ");
        string file = Console.ReadLine();
        if (file != "QUIT" || file != "quit" || file != "Quit")
        {
            _questBoard.Clear();
            string[] lines = System.IO.File.ReadAllLines(file);
            string[] stats = lines[0].Split("|");
            _level = int.Parse(stats[0]);
            _experience = int.Parse(stats[1]);
            _totalExperience = int.Parse(stats[2]);
            foreach (string line in lines.Skip(1))
            {
                string[] quest = line.Split("|");
                List<string> questing = quest.ToList();
                if (questing[0] == "Story")
                {
                    StoryQuest sand = new StoryQuest();
                    sand.LoadData(questing);
                    _questBoard.Add(sand);
                } 
                else if (questing[0] == "Repeat")
                {
                    RepeatQuest lightning = new RepeatQuest();
                    lightning.LoadData(questing);
                    _questBoard.Add(lightning);
                }
                else
                {
                    EliteQuest dough = new EliteQuest();
                    dough.LoadData(questing);
                    _questBoard.Add(dough);
                }
            }
            Console.WriteLine("Loading file");
            DotsAnimation2();
        }
    }
    private void CompleteQuest()
    {
        Console.Clear();
        Console.WriteLine("Which quest would you like to complete? Type 0 to cancel.");
        int d = 1;
        foreach (Quest quest in _questBoard)
        {
            quest.DisplayQuest(d);
            d +=1;
        }
        int selection = int.Parse(Console.ReadLine());
        if (selection != 0)
        {
            int bounty = _questBoard[selection-1].CompleteQuest();
            _experience += bounty;
            _totalExperience += bounty;
            DotsAnimation2();
            Console.WriteLine();
            LevelUp();
        }
    }
    private void DotsAnimation2()
    {
        for(int i = 0; i < 3; i++)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }
    }
}