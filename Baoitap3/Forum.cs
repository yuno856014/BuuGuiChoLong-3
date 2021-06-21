using System;
using System.Collections.Generic;
using System.Text;

namespace Baoitap3
{
    class Forum
    {
        static int id = 1;
        List<Post> PostList = new List<Post>();
        public void BuildMenu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("--------Menu--------");
                Console.WriteLine("1. Create Post         ");
                Console.WriteLine("2. Calculator     ");
                Console.WriteLine("3. Show list     ");
                Console.WriteLine("4. exit       ");
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    choice = 1;
                }
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        CreatePost();
                        break;
                    case 2:
                        Calculator();
                        break;
                    case 3:
                        ShowList();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            } while (choice != 0);
        }    
        public void CreatePost()
        {
            Post post = new Post();
            post.ID = id++;
            Console.WriteLine("Title :");
            post.Title = Console.ReadLine();
            Console.WriteLine("Content :");
            post.Content = Console.ReadLine();
            Console.WriteLine("Author :");
            post.Author = Console.ReadLine();
            for(int i = 0; i < 4;i++)
            {
                Console.WriteLine($"Rate {i} :");
                post[i] = int.Parse(Console.ReadLine());
            }
            PostList.Add(post);
        }
        public void Calculator()
        {
            if (PostList.Count > 0)
            {
                foreach (Post item in PostList)
                {
                    Console.WriteLine(item.CalculatorRate());
                    Console.WriteLine(item.Display());
                }
            }
            else
            {
                Console.WriteLine("Post is not found");
            }
        }
        public void ShowList()
        {
            foreach(Post post in PostList)
            {
                Console.WriteLine(post.Display());
            }    
        }
    }
}
