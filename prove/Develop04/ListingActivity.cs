using Microsoft.VisualBasic;

public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description) : base(name, description)
    {
        string[] prompts = {"Who are people that you appreciate?", "What are personal strengths of yours?","Who are people that you have helped this week?",
                    "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
        _prompts.AddRange(prompts);

    }

    public void Run(int duration)
    {
        _duration = duration;

        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        GetListFromUser();
        Console.WriteLine($"You have listed {_count} items.");
        Console.WriteLine();
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int randomPromptNumber = randomGenerator.Next(_prompts.Count);
        Console.WriteLine($"--- " + _prompts[randomPromptNumber] + " ---");
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        Console.WriteLine();

        while(DateTime.Now < endTime)
        {
            Console.Write("> ");
            string answer = Console.ReadLine();
            userList.Add(answer);
            _count++;
        }
        
        return userList;
    }
}