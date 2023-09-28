using System;
using System.Data.SqlTypes;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favnum = PromptUserNumber();
        int squarenum = SquareNumber(favnum);
        DisplayResult(name, squarenum);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favnum = int.Parse(Console.ReadLine());
        return favnum;
    }

    static int SquareNumber(int favnum)
    {
        return favnum * favnum;
    }

    static void DisplayResult(string username, int squarenum)
    {
        Console.WriteLine(username + ", the square of your number is " + squarenum);
    }
}