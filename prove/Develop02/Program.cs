using System;

class Program
{
    static void Main(string[] args)
    {
        UserUI();

    }

    static void UserUI() {
        int choice = 0;
        while (choice !=5) {
            if (choice == 1) {
                Entry.NewEntry();
            }else if (choice == 2) {
                Entry.DisplayJournal();
            }else if (choice == 3) {
                Journal.SaveJournal();
            }else if (choice == 4) {
                Journal.LoadJournal();
            }
            choice = DisplayMenu();
        }
    }

    static int DisplayMenu() {
        Console.WriteLine("Please type the number of the action you choose.");
        Console.WriteLine("1. Write a new Entry");
        Console.WriteLine("2. Display the Journal");
        Console.WriteLine("3. Save the Journal to a file");
        Console.WriteLine("4. Load the Journal from a file");
        Console.WriteLine("5. Close Program");
        int choice = int.Parse(Console.ReadLine());
        return choice;
    }

    
}