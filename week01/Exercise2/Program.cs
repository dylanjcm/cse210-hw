using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        string letterGrade = "";
        string sign = "";

        Console.WriteLine("What is your grade percentage? (0-100): ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int percentage))
        {

            int remainder = percentage % 10;
            if (remainder >= 7 && percentage < 100)
            {
                sign = "+";
            }
            else if (remainder < 3 && percentage >= 60)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }

            if (percentage >= 90 && percentage <= 100)
            {
                letterGrade = "A";
            }
            else if (percentage >= 80 && percentage < 90)
            {
                letterGrade = "B";
            }
            else if (percentage >= 70 && percentage < 80)
            {
                letterGrade = "C";
            }
            else if (percentage >= 60 && percentage < 70)
            {
                letterGrade = "D";
            }
            else if (percentage >= 0 && percentage < 60)
            {
                letterGrade = "F";
            }
            else
            {
                Console.WriteLine("Invalid percentage. Please enter a grade between 0 and 100.");
            }

            if (letterGrade == "A" && sign == "+")
            {
                sign = ""; // No A+ grade
            }

            if (letterGrade != "F" && letterGrade != "")
            {
                Console.WriteLine($"Your letter grade is: {letterGrade}{sign}");
                if (percentage >= 70)
                {
                    Console.WriteLine("Congratulations! You passed the class.");
                }
                else
                {
                    Console.WriteLine("Unfortunately, you did not pass the class.");
                }
            }
            else if (letterGrade == "F")
            {
                Console.WriteLine($"Your letter grade is: {letterGrade}");
                Console.WriteLine("Unfortunately, you did not pass the class.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric grade percentage.");
        }
    }
}