public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private List<int> unusedIndexes = new List<int>();
    

    public ReflectingActivity(string name, string description):base(name,description)
    {
        string[] prompts = {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.",
                    "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
        _prompts.AddRange(prompts);

        string[] questions = {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?",
                              "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?",
                              "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?",
                              "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
        _questions.AddRange(questions);

        for(int i=0; i < _prompts.Count; i++)
        {
            unusedIndexes.Add(i);
        }
    }

    public void Run(int duration)
    {
        _duration = duration;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        Console.WriteLine();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"---" + GetRandomPrompt() + "---");
        Console.WriteLine();
        Console.Write("When you have something in mind, press enter to continue ");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        while(DateTime.Now < endTime || unusedIndexes.Count == 0)
        {
            Console.Write($"> " + GetRandomQuestion() + " ");
            ShowSpinner(5);
            Console.WriteLine();
        }

        Console.WriteLine();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int unusedListIndex = randomGenerator.Next(unusedIndexes.Count);
        int randomPromptNumber = unusedIndexes[unusedListIndex];
        unusedIndexes.RemoveAt(unusedListIndex);
        return _prompts[randomPromptNumber];
        
    }

    public string GetRandomQuestion()
    {
        Random randomGenerator = new Random();
        int randomQuestionNumber = randomGenerator.Next(_prompts.Count);
        return _prompts[randomQuestionNumber];
    }

    public void DisplayPrompt()
    {

    }

    public void DisplayQuestions()
    {

    }
}