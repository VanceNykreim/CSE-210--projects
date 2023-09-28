using System;

class Program
{

    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int magicnum = int.Parse(Console.ReadLine());

        int guess = 0;
        do
        {Console.Write("What is your guess? ");
        guess = int.Parse(Console.ReadLine());

        if (magicnum > guess) {
            Console.WriteLine("Higher");
        } else if (magicnum < guess) {
            Console.WriteLine("Lower");
        } 
        } while (magicnum != guess);

        Console.Write("You guessed it!");
        
    }
}