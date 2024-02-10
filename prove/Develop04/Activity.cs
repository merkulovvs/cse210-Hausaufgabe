
public class Activity
{
    private string _name;
    private string _description;

    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of {_name} Activity");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string>();
        spinner.Add("[|]");
        spinner.Add("[/]");
        spinner.Add("[-]");
        spinner.Add("[\\]");
        spinner.Add("[|]");
        spinner.Add("[/]");
        spinner.Add("[-]");
        spinner.Add("[\\]");
        spinner.Add("[|]");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int index = 0;
        while(DateTime.Now < endTime)
        {
            string s = spinner[index];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b\b\b   \b\b\b");

            index++;

            if(index >= spinner.Count)
            {
                index = 1;
            }

        }
    }

    public void ShowCountDown(int seconds)
    {
        for(int i = seconds; i > 0; i--)
        {
            
            
            if(i <= 9)
            {   
                Console.Write(i); 
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            else if(i >= 10)
            {   
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b\b  \b\b");
            }

        }
    }

} 