// For the "Showing Creativity and Exceeding Requirements" requirement, I added a "Mood" field to the journal. Now when you write an entry, it also asks how you're feeling, saves it, and shows it when you display or load entries.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal myJournal = new Journal();
        string filename = "";

        bool running = true;
        while (running)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            int choice;
            bool validInput = int.TryParse(Console.ReadLine(), out choice);

            if (!validInput)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Entry entry1 = new Entry();
                    entry1._date = DateTime.Now.ToShortDateString();
                    entry1._promptText = new PromptGenerator().GetRandomPrompt();
                    Console.WriteLine($"Prompt: {entry1._promptText}");
                    Console.WriteLine("Enter your entry:");
                    entry1._entryText = Console.ReadLine();
                    Console.WriteLine("How are you feeling today?");
                    entry1._mood = Console.ReadLine();

                    myJournal.AddEntry(entry1);
                    break;
                case 2:
                    myJournal.DisplayAll();
                    break;
                case 3:
                    Console.WriteLine("Enter filename to load journal:");
                    filename = Console.ReadLine();
                    myJournal.LoadFromFile(filename);
                    break;
                case 4:
                    Console.WriteLine("Enter filename to save journal:");
                    filename = Console.ReadLine();
                    myJournal.SaveToFile(filename);
                    break;
                case 5:
                    Console.WriteLine("Goodbye!");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}