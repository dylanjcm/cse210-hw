/* Showing Creativity and Exceeding Requirements: To exceed requirements, I implemented a feature that prevents repeating random prompts or questions until all have been used once in that session. */
using System;

class Program
{
    static void Main()
    {
        bool running = true;
        while (running)
        {
            Activity.TryClear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    var b = new BreathingActivity();
                    b.Run();
                    break;
                case "2":
                    var r = new ReflectingActivity();
                    r.Run();
                    break;
                case "3":
                    var l = new ListingActivity();
                    l.Run();
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Press Enter to continue.");
                    Console.ReadLine();
                    break;
            }

            if (running)
            {
                Console.WriteLine("Press Enter to return to menu.");
                Console.ReadLine();
            }
        }
    }
}
