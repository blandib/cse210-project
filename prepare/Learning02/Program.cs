using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._jobTitle = "Computer Programmer";
        job1._company = "Google";
        job1._startYear = 2014;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Acounting";
        job2._company = "PNP";
        job2._startYear = 2020;
        job2._endYear = 2022;

        Resume myResume = new Resume();
        myResume._name = "Yams";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        //myResume._jobs[0]._jobTitle();

        myResume.Display();
    }
}