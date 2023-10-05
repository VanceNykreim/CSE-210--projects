using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> prompts = new List<string>();

        prompts.add("What was the most interesting part of my day?");
        prompts.add("What was the least interesting part of my day?");
        prompts.add("What was the most happy part of my day?");
        prompts.add("What was the most sad part of my day?");
        prompts.add("What happened at work/home today?");
        prompts.add("How did you make your spouse/friend/family member happy today?");
        prompts.add("What was the most interesting part of my day?");

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
        
        
    }
}