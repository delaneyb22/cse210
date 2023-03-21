using System;
using System.Collections.Generic;

namespace VideoComments
{
    class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Length { get; set; }
        public List<Comment> Comments { get; set; }

        public Video(string title, string author, int length)
        {
            Title = title;
            Author = author;
            Length = length;
            Comments = new List<Comment>();
        }

        public int GetNumComments()
        {
            return Comments.Count;
        }
    }

    class Comment
    {
        public string Name { get; set; }
        public string Text { get; set; }

        public Comment(string name, string text)
        {
            Name = name;
            Text = text;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();

            Video v1 = new Video("Best Places to Visit in Idaho", "Jane Doe", 350);
            v1.Comments.Add(new Comment("Mary", "This is awesome!"));
            v1.Comments.Add(new Comment("Bob", "#2 is my fav!"));
            v1.Comments.Add(new Comment("Karl", "Very helpful, thanks!"));
            videos.Add(v1);

            Video v2 = new Video("How to camp out of your car", "Johnny Karate", 300);
            v2.Comments.Add(new Comment("Emma", "This is so creative!"));
            v2.Comments.Add(new Comment("Kyle", "Very descriptive and inspiring."));
            videos.Add(v2);

            Video v3 = new Video("Best Hiking Gear For The Mountains", "Bear Grylls", 450);
            v3.Comments.Add(new Comment("David", "I already have some of these things, but now I know what to buy."));
            v3.Comments.Add(new Comment("Amy", "Would you have a link for the tent you mentioned?"));
            videos.Add(v3);

            foreach (Video v in videos)
            {
                Console.WriteLine("Title: " + v.Title);
                Console.WriteLine("Author: " + v.Author);
                Console.WriteLine("Length: " + v.Length + " seconds");
                Console.WriteLine("Number of comments: " + v.GetNumComments());
                Console.WriteLine("Comments:");

                foreach (Comment c in v.Comments)
                {
                    Console.WriteLine("- " + c.Name + ": " + c.Text);
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}