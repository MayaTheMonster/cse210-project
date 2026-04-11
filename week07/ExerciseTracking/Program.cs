using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> Exercise = new List<Activity>();
        Run activity1 = new Run(30,4.8);
        Bycicle activity2 = new Bycicle(60,24.3);
        Swim activity3 =  new Swim(40,8);
        Exercise.Add(activity1);
        Exercise.Add(activity2);
        Exercise.Add(activity3);
        
        foreach(Activity exercise in Exercise)
        {
            exercise.GetSummary();
        }
    }
}