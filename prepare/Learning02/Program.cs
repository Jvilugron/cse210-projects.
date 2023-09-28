using System;

class Program
{
    static void Main()
    {
        // Create job instances
        Job job1 = new Job("Software Engineer", "Microsoft", "2019-2022");
        Job job2 = new Job("Manager", "Apple", "2022-2023");

        // Display job details
        job1.DisplayJobDetails();
        job2.DisplayJobDetails();

        // Create a resume
        Resume myResume = new Resume("Allison Rose");

        // Add jobs to the resume
        myResume.AddJob(job1);
        myResume.AddJob(job2);

        // Display resume details
        myResume.Display();
    }
}
