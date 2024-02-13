public class GoalManager
{
    List<Goal> _goals;
    int _score;

    public GoalManager()
    {
       _score = 0;
       _goals = new List<Goal>();
    }
    public void Start()
    { 
        Console.WriteLine($"You have {_score} points");
        Console.WriteLine();

        int choice = 0;
        while(choice != 6)
        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("\t1. Create New Goal.");
            Console.WriteLine("\t2. List Goals.");
            Console.WriteLine("\t3. Save Goals.");
            Console.WriteLine("\t4. Load Goals.");
            Console.WriteLine("\t5. Record Event.");
            Console.WriteLine("\t6. Quit.");
            Console.Write("Select a choice from the menu: ");
            string choiceStr = Console.ReadLine();
            choice = Int32.Parse(choiceStr);

            if(choice == 1)
            {
                CreateGoal();
            }
            else if(choice == 2)
            {
                ListGoalNames();
            }
            else if(choice == 3)
            {
                SaveGoals();
            }
            else if(choice == 4)
            {
                LoadGoals();
            }
            else if(choice == 5)
            {
                RecordEvent();
            }


        }    
        
    }

    public void DisplayPlayerInfo()
    {

    }

    public void ListGoalNames()
    {
        Console.Clear();
        Console.WriteLine("Goals names");
        Thread.Sleep(10000);
    }

    public void ListGoalDetails()
    {

    }

    public void CreateGoal()
    {

    }

    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {

    }


}