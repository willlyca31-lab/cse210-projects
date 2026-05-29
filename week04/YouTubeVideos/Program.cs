using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Learning C#", "Code Academy", 600);
        video1.AddComment(new Comment("John", "Great tutorial!"));
        video1.AddComment(new Comment("Maria", "Very helpful."));
        video1.AddComment(new Comment("David", "Easy to understand."));

        Video video2 = new Video("Web Development Basics", "Tech World", 750);
        video2.AddComment(new Comment("Sophia", "Excellent explanation."));
        video2.AddComment(new Comment("James", "Thanks for sharing."));
        video2.AddComment(new Comment("Emma", "I learned a lot."));

        Video video3 = new Video("Object-Oriented Programming", "Programming Hub", 900);
        video3.AddComment(new Comment("Daniel", "Nice examples."));
        video3.AddComment(new Comment("Olivia", "This helped me with homework."));
        video3.AddComment(new Comment("Noah", "Good pacing."));

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}