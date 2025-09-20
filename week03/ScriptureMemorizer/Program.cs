// Showing Creativity and Exceeding Requirements: Made the program support a library of multiple scriptures. Each time the program runs, one scripture is chosen at random for the user to practice.
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding. " +
                "In all thy ways acknowledge him, and he shall direct thy paths."),
            
            new Scripture(new Reference("John", 3, 16),
                "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            
            new Scripture(new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me.")
        };

        Random rand = new Random();
        Scripture scripture = scriptures[rand.Next(scriptures.Count)];

        while (true)
        {
            TryClear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input?.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                TryClear();
                Console.WriteLine(scripture.GetDisplayText());
                break;
            }
        }
    }

    static void TryClear()
    {
        try
        {
            Console.Clear();
        }
        catch (System.IO.IOException)
        {
            // Fallback for environments where Console.Clear() is not supported since it throws an IOException when I try it on VSCode terminal
            Console.WriteLine(new string('\n', 40));
        }
    }
}
