using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create video objects
        Video video1 = new Video("Understanding Abstraction in OOP", "John Doe", 600);
        Video video2 = new Video("C# Tutorial for Beginners", "Jane Smith", 1200);
        Video video3 = new Video("Learn Design Patterns", "Bob Johnson", 900);

        // Add comments to each video
        video1.AddComment(new Comment("Alice", "Thanks I understand everything."));
        video1.AddComment(new Comment("Charlie", "Very informative."));
        video1.AddComment(new Comment("Bob", "Loved it!"));

        video2.AddComment(new Comment("Alice", "This was so good!"));
        video2.AddComment(new Comment("David", "Excelent tips!"));
        video2.AddComment(new Comment("Eve", "Good for beginners."));

        video3.AddComment(new Comment("Frank", "This is advanced stuff."));
        video3.AddComment(new Comment("Grace", "Very useful."));
        video3.AddComment(new Comment("Heidi", "Thank you!"));

        // Create a list of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video information
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Duration} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
