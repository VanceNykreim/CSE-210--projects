using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int percent = int.Parse(Console.ReadLine());
        string grade;
        if (percent > 100 || percent < 0)
        {
            Console.Write("This is an invalid number.");
            return;
        }

        if (percent >= 90)
        {
            grade = "A";
        } else if (percent >= 80)
        {
            grade = "B";
        } else if (percent >= 70)
        {
            grade = "C";
        } else if (percent >= 60)
        {
            grade = "D";
        } else 
        {
            grade = "F";
        }
        
        if (percent % 10 >= 7 && percent >59)
        {
            grade = grade + "+";
        } else if ( percent % 10 <= 3 && percent >59)
        {
            grade = grade + "-";
        }

        if (percent == 100)
        {
            grade = "A+";
        }
        Console.WriteLine($"Your grade is {grade}");
    }
}