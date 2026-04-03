public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void RunBreathingActivity()
    {
        DisplayStartingMessage();
        int runtime = 0; 
        while (runtime < _duration)
        {
            Console.Write("Breath in...");
            ShowCountDown(4);
            Console.Write("Now Breathe out...");
            ShowCountDown(6);
            Console.WriteLine();
            runtime += 10;
        }
        DisplayEndingMessage();
    }
}