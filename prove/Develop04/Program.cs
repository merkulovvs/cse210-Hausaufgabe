using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        
        int userChoise = 0;
        
        while(userChoise != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Start breathing activity.");
            Console.WriteLine("\t2. Start reflecting activity.");
            Console.WriteLine("\t3. Start listening activity.");
            Console.WriteLine("\t4. Quit.");
            Console.Write("Select a choice from the menu: ");

            string usersChoiseActivity = Console.ReadLine(); 
            userChoise = Int32.Parse(usersChoiseActivity);

            if(userChoise == 1)
            {
                Console.Clear();
                BreathingActivity activity1 = new BreathingActivity("Breathing", "This activity will help you relax by prompting you to breath slowly. Clear your mind and focus on your breathing.");

                activity1.DisplayStartingMessage();
                Console.WriteLine();
                
                Console.Write("How long, in seconds, would you like for your session? ");
                string durationStr = Console.ReadLine();
                Console.WriteLine();
                int durationInt = Int32.Parse(durationStr);
                Console.Clear();
                Console.WriteLine("Get ready...");
                activity1.ShowSpinner(8);
                activity1.Run(durationInt);
            
            } 

            else if(userChoise == 2)
            {
                Console.Clear();
                ReflectingActivity activity2 = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strenght and resilience. This will help you recognize the power you have and how you can use it in other acpects of your life");
                
                activity2.DisplayStartingMessage();
                Console.WriteLine();
                
                Console.Write("How long, in seconds, would you like for your session? ");
                string durationStr = Console.ReadLine();
                Console.WriteLine();
                int durationInt = Int32.Parse(durationStr);
                Console.Clear();
                Console.WriteLine("Get ready...");
                activity2.ShowSpinner(8);
                activity2.Run(durationInt);

                
            }

            else if(userChoise == 3)
            {

            }

            else if(userChoise == 4)
            {
                Console.WriteLine();
                Thread.Sleep(1000);
                Console.WriteLine("Goodbye!");
            }



        }
        
        //activity.ShowSpinner(20);

        //activity.ShowCountDown(20);
    }
}