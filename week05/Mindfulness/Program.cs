// Added Naming Activity, an activity where you name objects that start with a given letter, also updated the spinner in a way that 
//in my oppinion looks better
using System;

class Program
{
    static void Main(string[] args)
    {
        bool executing = true;
        
        while (executing == true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:\n 1. Start breating activity\n 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity\n 4. Start naming actvity\n 5. Quit\nSelect a choice from the menu: ");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                BreathingActivity novel = new BreathingActivity();
                novel.RunBreathingActivity();
            }
            else if(answer == "2")
            {
                ReflectionActivity novel = new ReflectionActivity();
                novel.RunReflection();
            }
            else if(answer == "3")
            {
                ListingActivity novel = new ListingActivity();
                novel.RunListingActivity();
            }
            else if(answer == "4")
            {
                NamingActivity novel = new NamingActivity();
                novel.RunNamingActivity();
            }
            else
            {
                executing = false;
            }
        }
    }
}