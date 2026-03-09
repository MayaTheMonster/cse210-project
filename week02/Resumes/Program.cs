using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startTime = "2019";
        job1._endTime = "2022";

        Job job2 = new Job();

        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startTime = "2022";
        job2._endTime = "2023";
    
        Resume resume1 = new Resume();
        resume1._member = "Allison Rose";
        resume1._Job.Add(job1);
        resume1._Job.Add(job2);

        resume1.DisplayResume();
    }
}