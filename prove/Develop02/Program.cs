using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        
        Journal journal = new Journal();

        string _userChoise = "";

        while(_userChoise != "5")
        {
          Console.Write("Please chose (enter number from 1 to 5): ");
          _userChoise = Console.ReadLine(); 
          Console.WriteLine("1. Write an entry");
          Console.WriteLine("2. Display entry");
          Console.WriteLine("3. Load entries");
          Console.WriteLine("4. Save entry");
          Console.WriteLine("5. Quit");

          if(_userChoise == "1")
          {
            Console.WriteLine("You have entered 1");
                        
            PromptGenerator newPrompt = new PromptGenerator();
            newPrompt._prompts.Add("What made you smile today?");
            newPrompt._prompts.Add("What did you do well today?");
            newPrompt._prompts.Add("What would you do differently today?");
            newPrompt._prompts.Add("What did your child do today?");
            newPrompt._prompts.Add("How did you help your wife today?");
            foreach(string prompt in newPrompt._prompts)
            {
              Console.WriteLine(prompt);
            }
            string randomPrompt = newPrompt.GetRandomPrompt();
            Console.WriteLine(randomPrompt);
            Console.Write("> ");
            string userEntry = Console.ReadLine();
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();

            Entry newEntry = new Entry();
            newEntry._date = dateText;
            newEntry._promptText = randomPrompt;
            newEntry._entryText = userEntry;
            journal.AddEntry(newEntry);
            Console.WriteLine($"{userEntry}");
          }

          else if(_userChoise == "2")
          {
            Console.WriteLine("You have chosen 2");
            journal.DisplayAll();
          }

          else if(_userChoise == "3")
          {
            Console.Write("Please, enter the file name from which you would like to load your entries: ");
            string fileName = Console.ReadLine();
            Console.WriteLine("Loading from your file . . .");
            journal.LoadFromFile("journal.txt");
          }

          else if(_userChoise == "4")
          {
            Console.Write("Please, enter the file name where you would like to save your entries: ");
            string fileName = Console.ReadLine();
            Console.WriteLine("Saving your entries . . .");
            journal.SaveToFile(fileName);
          }
            
          else if(_userChoise == "5")
          {
            Console.WriteLine("Good bye.");
          }

        }
    }    
}   
        
        
    