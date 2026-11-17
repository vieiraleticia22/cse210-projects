using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("C# Tutorial", "John Doe", 600);
        Video video2 = new Video("Python Tutorial", "Jane Smith", 900);
        Video video3 = new Video("Java Tutorial", "Mike Johnson", 1200);

        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "I learned a lot from this video."));

        video2.AddComment(new Comment("David", "Excellent explanation!"));
        video2.AddComment(new Comment("Eve", "I appreciate the clear instructions."));
        video2.AddComment(new Comment("Frank", "This video made complex concepts easy to understand."));

        video3.AddComment(new Comment("Grace", "Fantastic tutorial!"));
        video3.AddComment(new Comment("Heidi", "I really enjoyed the examples provided."));
        video3.AddComment(new Comment("Ivan", "This video helped me a lot in my project."));

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetComment()}");
            }
            Console.WriteLine();
        }
    }
}