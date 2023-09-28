using System;

public class Job
{
    // Member variables
    private string _jobTitle;
    private string _company;
    private string _employmentDates;

    // Constructor to initialize the member variables
    public Job(string jobTitle, string company, string employmentDates)
    {
        _jobTitle = jobTitle;
        _company = company;
        _employmentDates = employmentDates;
    }

    // Display job details
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_employmentDates}");
    }
}
