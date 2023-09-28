using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job
        {
            Company = "Agropur Inc.",
            JobTitle = "IT Intern",
            StartYear = 2023,
            EndYear = 2023
        };

        Job job2 = new Job
        {
            Company = "Tremco",
            JobTitle = "Software Development Intern",
            StartYear = 2023,
            EndYear = 2024
        };

        Resume resume1 = new Resume
        {
            Name = "Vance Nykreim",
            Jobs = new List<Job> {job1, job2}
        };

        resume1.DisplayResume();

    }
}