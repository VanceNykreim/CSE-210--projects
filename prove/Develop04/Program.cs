using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemory
{
    // A class to represent a scripture reference, such as "John 3:16" or "Proverbs 3:5-6"
    public class Reference
    {
        public string Book { get; set; } // The name of the book, such as "John" or "Proverbs"
        public int Chapter { get; set; } // The chapter number, such as 3
        public int StartVerse { get; set; } // The starting verse number, such as 16 or 5
        public int EndVerse { get; set; } // The ending verse number, such as 6 or -1 if there is no range

        // A constructor that takes a single verse reference, such as "John 3:16"
        public Reference(string book, int chapter, int verse)
        {
            Book = book;
            Chapter = chapter;
            StartVerse = verse;
            EndVerse = -1; // Indicates no range
        }

        // A constructor that takes a verse range reference, such as "Proverbs 3:5-6"
        public Reference(string book, int chapter, int startVerse, int endVerse)
        {
            Book = book;
            Chapter = chapter;
            StartVerse = startVerse;
            EndVerse = endVerse;
        }

        // A method that returns the string representation of the reference, such as "John 3:16" or "Proverbs 3:5-6"
        public override string ToString()
        {
            if (EndVerse == -1) // No range
            {
                return $"{Book} {Chapter}:{StartVerse}";
            }
            else // Range
            {
                return $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
            }
        }
    }

    // A class to represent a word in the scripture text, such as "God" or "love"
    public class Word
    {
        public string Text { get; set; } // The text of the word, such as "God" or "love"
        public bool IsHidden { get; set; } // A flag that indicates whether the word is hidden or not

        // A constructor that takes the text of the word and sets the hidden flag to false by default
        public Word(string text)
        {
            Text = text;
            IsHidden = false;
        }

        // A method that returns the string representation of the word, either the text or an underscore depending on the hidden flag
        public override string ToString()
        {
            if (IsHidden) // Hidden
            {
                return "_";
            }
            else // Not hidden
            {
                return Text;
            }
        }
    }

    // A class to represent a scripture, including both the reference and the text
    public class Scripture
    {
        public Reference Reference { get; set; } // The reference of the scripture, such as "John 3:16" or "Proverbs 3:5-6"
        public List<Word> Words { get; set; } // The list of words in the scripture text

        // A constructor that takes a reference and a text and splits the text into words
        public Scripture(Reference reference, string text)
        {
            Reference = reference;
            Words = new List<Word>();
            string[] tokens = text.Split(' '); // Split the text by spaces
            foreach (string token in tokens)
            {
                Words.Add(new Word(token)); // Add each token as a word to the list
            }
        }

        // A method that returns the string representation of the scripture, including both the reference and the text
        public override string ToString()
        {
            string result = $"{Reference}\n"; // Start with the reference
            foreach (Word word in Words)
            {
                result += $"{word} "; // Add each word with a space
            }
            return result.Trim(); // Remove any trailing spaces and return the result
        }

        // A method that hides a random word in the scripture text by setting its hidden flag to true
        public void HideRandomWord()
        {
            Random random = new Random(); // Create a random object
            int index = random.Next(Words.Count); // Generate a random index between 0 and the number of words
            Words[index].IsHidden = true; // Set the hidden flag of the word at that index to true
        }

        // A method that returns true if all words in the scripture text are hidden, false otherwise
        public bool IsAllHidden()
        {
            foreach (Word word in Words)
            {
                if (!word.IsHidden) // If any word is not hidden
                {
                    return false; // Return false
                }
            }
            return true; // Otherwise, return true
        }
    }

    // The main program class
    public class Program
    {
        // The main method
        public static void Main(string[] args)
        {
            // Create a scripture object with a reference and a text
            Scripture scripture = new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

            // Clear the console screen and display the complete scripture
            Console.Clear();
            Console.WriteLine(scripture);

            // Prompt the user to press the enter key or type quit
            Console.WriteLine("\nPress the enter key to hide a word or type quit to end the program.");
            string input = Console.ReadLine();

            // Loop until the user types quit or all words are hidden
            while (input != "quit" && !scripture.IsAllHidden())
            {
                // Hide a random word in the scripture text
                scripture.HideRandomWord();

                // Clear the console screen and display the scripture again
                Console.Clear();
                Console.WriteLine(scripture);

                // Prompt the user to press the enter key or type quit
                Console.WriteLine("\nPress the enter key to hide another word or type quit to end the program.");
                input = Console.ReadLine();
            }

            // If all words are hidden, display a message
            if (scripture.IsAllHidden())
            {
                Console.WriteLine("\nAll words are hidden. Goodbye!");
            }
        }
    }
}