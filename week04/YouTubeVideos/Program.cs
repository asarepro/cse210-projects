using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
//     }
// }

// Program.cs
class Program
{
    static void Main(string[] args)
    {
        // Create videos
        var video1 = new Video("How to Cook Jollof Rice", "Chef Ama", 600);
        var video2 = new Video("Learn C# in 10 Minutes", "CodeMaster", 720);
        var video3 = new Video("Top 5 Beaches in Ghana", "TravelTime", 480);

        // Add comments
        video1.AddComment(new Comment("Kojo", "Looks delicious!"));
        video1.AddComment(new Comment("Linda", "My mum makes it better 😅"));
        video1.AddComment(new Comment("Kwame", "Thanks for the tips!"));

        video2.AddComment(new Comment("Angela", "Super helpful tutorial."));
        video2.AddComment(new Comment("Tunde", "Can you do one for Python too?"));
        video2.AddComment(new Comment("Akosua", "Learnt more in 10 mins than in class!"));

        video3.AddComment(new Comment("Jake", "Adding these to my bucket list."));
        video3.AddComment(new Comment("Naana", "You missed Cape Three Points!"));
        video3.AddComment(new Comment("Kofi", "Beautiful visuals!"));

        // Store videos in a list
        var videos = new List<Video> { video1, video2, video3 };

        // Display each video and its comments
        foreach (var video in videos)
        {
            Console.WriteLine($"\nTitle: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
        }
    }
}