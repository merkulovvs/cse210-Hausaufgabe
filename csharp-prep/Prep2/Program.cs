using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "EPAM";
        job1._startYear = 2007;
        job1._endYear = 2010;

        Job job2 = new Job();
        job2._jobTitle = "Senior Software Engineer";
        job2._company = "Luxsoft";
        job2._startYear = 2010;
        job2._endYear = 2019;

        Resume myResume = new Resume();
        myResume._name = "Victor Merkulov";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();          
    

    }
}