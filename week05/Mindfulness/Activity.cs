using System;
using System.Threading;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        TryClear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like your session to last? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\nGet ready to begin...");
        ShowDots(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowDots(3);
        Console.WriteLine($"\nYou have completed the {_name} for {_duration} seconds.");
        ShowDots(5);
    }

    // ✅ NEW: Dot-based spinner function
    public void ShowDots(int seconds)
    {
        int totalDots = seconds * 2; // two dots per second for better pacing
        for (int i = 0; i < totalDots; i++)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }
        Console.WriteLine(); // move to next line after animation
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            // carriage return then clear (works for small ints)
            Console.Write("\r" + new string(' ', i.ToString().Length) + "\r");
        }
    }

    public static void TryClear()
    {
        try
        {
            Console.Clear();
        }
        catch
        {
            // Ignore any exceptions (e.g., if running in an environment that doesn't support Clear)
        }
    }

    public abstract void Run();
}
