using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learning C#", "Alice", 600);
        video1.AddComment(new Comment("John", "Great explanation!"));
        video1.AddComment(new Comment("Mary", "Helped me a lot, thanks!"));
        video1.AddComment(new Comment("Steve", "Clear and concise."));
        videos.Add(video1);

        Video video2 = new Video("Design Patterns", "Bob", 1200);
        video2.AddComment(new Comment("Laura", "Very useful examples."));
        video2.AddComment(new Comment("Chris", "I finally get it now."));
        video2.AddComment(new Comment("Nina", "Could you cover Singleton next?"));
        video2.AddComment(new Comment("Tom", "Awesome content!"));
        videos.Add(video2);

        Video video3 = new Video("LINQ Basics", "Carol", 900);
        video3.AddComment(new Comment("Ethan", "LINQ is awesome."));
        video3.AddComment(new Comment("Sophia", "So much easier to understand now."));
        video3.AddComment(new Comment("Mia", "Thanks for the demo!"));
        video3.AddComment(new Comment("Liam", "Very informative."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.GetCommenterName()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }
    }
}
