using System;
using System.Diagnostics.CodeAnalysis;

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
        Journal journal = new Journal();

        UserUI(journal, prompts);
        
    }

    static void UserUI(Journal journal, List<string> prompts) {
        int choice = 0;
        while (choice !=5) {
            if (choice == 1) {
                //run NewEntry program to create a new entry
                Entry entry = new Entry();
                entry = NewEntry(prompts);
                journal.Entries.Add(entry);
                Console.WriteLine();

            }else if (choice == 2) {

                DisplayJournal(journal);

            }else if (choice == 3) {
                //save journal.Entries to file
                InputJournal(journal);

            }else if (choice == 4) {
                //Load journal from file
                journal = LoadFromFile(journal);
            }
            choice = DisplayMenu();
        }
    }

    static Journal LoadFromFile (Journal journal) {
        Console.WriteLine("Enter the filename of the journal you'd like to load.");
        string filename = Console.ReadLine();
        //if (filename != "ice") {
        //    Console.WriteLine("Unknown File. Please try again. ");
        //    filename = Console.ReadLine();
        //}
        string[] lines = System.IO.File.ReadAllLines(filename); 
        int i = 1;
        int j = 0;
        string date = "";
        string prompt = "";
        string response = "";
        foreach (string line in lines)
        {
        if (i % 3 == 1) {
            string[] parts = line.Split(": ");
            string fat_date = parts[1];
            date = fat_date.Substring(0, Math.Min(fat_date.Length, 10));
            prompt = parts[2];
        } else if (i % 3 == 2) {
            response = line;
        } else if (i % 3 == 0) {
            Entry entry = new Entry();
            entry.EntryDate = date;
            entry.Prompt = prompt;
            entry.Response = response;
            journal.Entries.Add(entry);
            j++;
        }
        i++;
        }


        return journal;
    }
    static Entry NewEntry(List<string> prompts) {
        //choose random prompt
        Random rnd = new Random();
        int r = rnd.Next(prompts.Count);
        Entry entry = new Entry();
        entry.Prompt = prompts[r]; // from prompt above
        Console.WriteLine(entry.Prompt);
        Console.Write("> ");
        entry.Response = Console.ReadLine();
        entry.EntryDate = DateTime.Now.ToShortDateString();
        return entry;
    }
    static void InputJournal(Journal journal) {
         Console.WriteLine("Please type a filename/location to save your entry (Hit Enter for unique filename under entry/ :");
            string fileLocation = Console.ReadLine();
            string date = DateTime.Now.Ticks.ToString();
            if (fileLocation == "") {
                fileLocation = $"entry/entries{date}.txt";
            }

            using (StreamWriter outputFile = new StreamWriter(fileLocation))
            {
                int i = 0;
            // You can use the $ and include variables just like with Console.WriteLine
                while (i <= journal.Entries.Count - 1) {
                outputFile.WriteLine($"Date: {journal.Entries[i].EntryDate} - Prompt: {journal.Entries[i].Prompt}");
                outputFile.WriteLine($"{journal.Entries[i].Response}");
                outputFile.WriteLine();
                i++;
                }
            }
            Console.WriteLine("Your Entry/Entries has been saved.");
    }

    static void DisplayJournal(Journal journal) {
        int i = 0;
        while (i <= journal.Entries.Count - 1) {
            Console.WriteLine($"Date: {journal.Entries[i].EntryDate} - Prompt: {journal.Entries[i].Prompt}");
            Console.WriteLine($"{journal.Entries[i].Response}");
            Console.WriteLine();
            i++;
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