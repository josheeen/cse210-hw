using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2018;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Developer";
        job2._startYear = 2017;
        job2._endYear = 2022;


        //Console.WriteLine(job1._company);
        // job1.Display();
        // job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Joshua Gil R.";

        

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //Console.WriteLine(myResume._jobs[0]._jobTitle);

        myResume.Display();
    }
}