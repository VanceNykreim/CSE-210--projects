using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> prompts = new List<string>();

        prompts.Add("What was the most interesting part of my day?");
        prompts.Add("What was the least interesting part of my day?");
        prompts.Add("What was the most happy part of my day?");
        prompts.Add("What was the most sad part of my day?");
        prompts.Add("What happened at work/home today?");
        prompts.Add("How did you make your spouse/friend/family member happy today?");
        prompts.Add("What was the most interesting part of my day?");

        //if user picks option to add a new entry
        //1. pick a random prompt from list above
        //2. Display random prompt
        //3. save response from user
        //4. create response object
        //5. save response object to Journal object
        Entry entry = new Entry();
        entry.EntryDate = DateTime.Now.ToShortDateString();
        entry.Prompt = ""; // from prompt above
        entry.Response = ""; // from prompt above

        Journal journal = new Journal();
        journal.JournalName = ""; //ask user for their name
        journal.Entries.Add(entry);
        
        UserUI();
        
    }

    static void UserUI() {
        int choice = 0;
        while (choice !=5) {
            if (choice == 1) {
                Console.WriteLine("Yo Dog");
            }else if (choice == 2) {
                Console.WriteLine("Yo Dog");
            }else if (choice == 3) {
                Console.WriteLine("Yo Dog");
            }else if (choice == 4) {
                Console.WriteLine("Yo Dog");
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