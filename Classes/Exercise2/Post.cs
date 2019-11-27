using System;

namespace Exercise2
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public readonly DateTime CreatedTime;

        private int _vote;

        public Post()
        {
            CreatedTime = DateTime.Now;
        }

        public Post(string title, string description):this()
        {
            Title = title;
            Description = description;
        }

        public void UpVote()
        {
            _vote++;
            Console.WriteLine("Make c# great again");
        }

        public void DownVote()
        {
            _vote--;
            Console.WriteLine($"Down voteeeeee");
        }

        public void GetVotes()
        {
            Console.WriteLine($"Current Oy: {_vote}");
        }
    }
}