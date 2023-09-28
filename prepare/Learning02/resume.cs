using System.Collections.Generic;

public class Resume
{
    // Member variable for the person's name
    public string _name;
    // Member variable for the list of Jobs
    public List<Job> _jobs = new List<Job>();

    // Constructor to initialize the name
    public Resume(string name)
    {
        _name = name;
    }

    // Add a job to the list
    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    // Display resume details
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (var job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}
