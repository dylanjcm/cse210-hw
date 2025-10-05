// BreathingActivity.cs
using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity",
               "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);   // example: 4 seconds inhale
            Console.WriteLine();
            Console.WriteLine("Breathe out...");
            ShowCountdown(6);   // example: 6 seconds exhale
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}
