using System;

class Program
{
    static void Main(string[] args)
    {
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
          }
          else if(_userChoise == "2")
          {
            Console.WriteLine("You have chosen 2");
          }
          else if(_userChoise == "3")
          {
            Console.WriteLine("You have chosen 3");
          }
          else if(_userChoise == "4")
          {
            Console.WriteLine("You have chosen 4");
          }
            
          else if(_userChoise == "5")
          {
            Console.WriteLine("Good bye");
          }
        }
    }
}