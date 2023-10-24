using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        //Step One and Two
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("What is your topic?");
        string topic = Console.ReadLine();
        Assignment testAssignment = new Assignment(name, topic);


        // Step 3 and 4
        Console.WriteLine("What Section?");
        string section = "Section " + Console.ReadLine();
        Console.WriteLine("What problems?");
        string problems = "Problems " + Console.ReadLine();
        MathAssignment mathjob = new MathAssignment(name, topic, section, problems);


        string summary = mathjob.GetSummary();
        Console.WriteLine(summary);
        Console.WriteLine();
        Console.WriteLine("Your Homework List is: ");
        string list = mathjob.GetHomeworkList();
        Console.WriteLine(list);
        Console.WriteLine();
    
        // Step 5
        Console.WriteLine("What is the title?");
        string title = Console.ReadLine();

        WritingAssignment paper = new WritingAssignment(name, topic, title);
        string writing = paper.GetWritingInformation();

        Console.WriteLine("Your Writing info is: ");
        Console.WriteLine();
        Console.WriteLine(writing);
    }
}