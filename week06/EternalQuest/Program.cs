//Renamed goals to "Quests" for a more fantastic setting, added loading dots when creating quests, added leveling systems, changed wording
//according to this more fantastic setting I created, made eternal quests display how many times they have been completed, made checklist quests
//calculate automatically the bonus value of completing the full desired ammount by multiplying the ammount you earn each time you
//complete a quest by the ammount you have to complete, added the option of deleting quests from the quest board
using System;

class Program
{
    static void Main(string[] args)
    {
        Portal system = new Portal();
        system.Start();
        Console.WriteLine("Quitting program now.");
    }
}