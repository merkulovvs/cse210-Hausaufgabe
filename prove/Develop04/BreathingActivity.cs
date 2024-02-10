public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description):base(name, description)
    {

    }

    public void Run(int duration)
    {
        _duration = duration;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        Console.WriteLine();
        
        while(DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(6);
            Console.WriteLine("\n");
        }

        DisplayEndingMessage();
    }
}