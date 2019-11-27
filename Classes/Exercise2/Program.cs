using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Design a class called Post. This class models a StackOverflow post. It should have properties
for title, description and the date/time it was created. We should be able to up-vote or down-vote
a post. We should also be able to see the current vote value. In the main method, create a post,
up-vote and down-vote it a few times and then display the the current vote value.
In this exercise, you will learn that a StackOverflow post should provide methods for up-voting
and down-voting. You should not give the ability to set the Vote property from the outside,
because otherwise, you may accidentally change the votes of a class to 0 or to a random
number. And this is how we create bugs in our programs. The class should always protect its
state and hide its implementation detail. */


            var post = new Post("Trump", "asdasd");
            while (true)
            {
                Console.WriteLine("Up vote: 1 - Down Vote 2, çıkmak için random birşey yazınız");
                post.GetVotes();
                var result = Console.ReadLine();
                if (result == "1")
                {
                    post.UpVote();
                }
                else if (result == "2")
                {
                    post.DownVote();
                }
                else
                {
                    Console.WriteLine($"Title: {post.Title} Description: {post.Description} CreatedTime: {post.CreatedTime}");
                    post.GetVotes();
                    break;
                }
            }
        }
    }
}
