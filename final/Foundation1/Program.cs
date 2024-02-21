using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video video1 = new Video("Cat meowing", "Grandma May", 5);
        _videos.Add(video1);
        Comment comment1_1 = new Comment("Joe", "Nice");
        video1.StoreComment(comment1_1);
        Comment comment1_2 = new Comment("Hope", "So cute");
        video1.StoreComment(comment1_2);
        Comment comment1_3 = new Comment("Emma", "I hate cats");
        video1.StoreComment(comment1_3);

        Video video2 = new Video("Dogs barking", "Jessie J.", 2);
        _videos.Add(video2);
        Comment comment2_1 = new Comment("Joe", "Nice");
        video2.StoreComment(comment2_1);
        Comment comment2_2 = new Comment("Hope", "So cute");
        video2.StoreComment(comment2_2);
        Comment comment2_3 = new Comment("Emma", "I hate dogs");
        video2.StoreComment(comment2_3);

        Video video3 = new Video("Bird singing", "Mario", 10);
        _videos.Add(video3);
        Comment comment3_1 = new Comment("Joe", "Nice");
        video3.StoreComment(comment3_1);
        Comment comment3_2 = new Comment("Hope", "So cute");
        video3.StoreComment(comment3_2);
        Comment comment3_3 = new Comment("Emma", "I hate birds");
        video3.StoreComment(comment3_3);
        Comment comment3_4 = new Comment("Mike", "Amazing");
        video3.StoreComment(comment3_4);

        foreach(Video vid in _videos)
        {
            Console.WriteLine($"Video {_videos.IndexOf(vid) + 1}\nTitle: {vid.GetTitle()}; Author: {vid.GetAuthor()}; Length: {vid.GetLength()} min; Number of comments: {vid.numberOfComments()}");
            foreach(Comment com in vid.GetComments())
            {
                Console.WriteLine($"\tComment {vid.GetComments().IndexOf(com) + 1}: {com.GetName()} - \"{com.GetText()}\"");
            }
        }



    }
}