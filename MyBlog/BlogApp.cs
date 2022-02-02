using System;

namespace MyBlog
{
    public class BlogApp
    {
        private Blog blog;
        private BlogWrapper blogWrapper;
        private bool canRun = true;

        public BlogApp()
        {
            blog = new Blog();
            blogWrapper = new BlogWrapper(blog);
        }

        public void Run()
        {
            while (canRun)
            {
                MainMenu();
            }
        }

        private void MainMenu()
        {
            PrintMainMenu();
            HandleInput();
        }

        private void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("MyBlog");
            if (blog.GetCategories().Count != 0)
            {
                Console.WriteLine("Kategorie: ");
                foreach (var category in blog.GetCategories())
                {
                    Console.WriteLine(category);
                }
            }

            if (blog.GetAuthors().Count != 0)
            {
                Console.WriteLine("Autoři: ");
                foreach (var author in blog.GetAuthors())
                {
                    Console.WriteLine(author);
                }
            }

            Console.WriteLine("Moznosti:");
            Console.WriteLine("1) Přidat kategorii");
            Console.WriteLine("2) Přidat autora");

            if (blog.GetCategories().Count != 0)
            {
                Console.WriteLine("3) Otevřít kategorii");
            }

            if (blog.GetAuthors().Count != 0)
            {
                Console.WriteLine("4) Zobrazit info o autorovi");
            }
        }

        private const string EXIT = "5";
        private const string AUTHOR_INFO = "4";
        private const string OPEN_CATEGORY = "3";
        private const string ADD_AUTHOR = "2";
        private const string ADD_CATEGORY = "1";

        private void HandleInput()
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case ADD_CATEGORY:
                {
                    blogWrapper.AddCategory();
                }
                    break;
                case ADD_AUTHOR:
                {
                    blogWrapper.AddAuthor();
                }
                    break;
                case OPEN_CATEGORY:
                {
                    if (blog.GetCategories().Count != 0)
                    {
                        blogWrapper.OpenCategory();
                    }
                }
                    break;
                case AUTHOR_INFO:
                {
                    if (blog.GetAuthors().Count != 0)
                    {
                        blogWrapper.AuthorInfo();
                    }
                }
                    break;
                case EXIT:
                {
                    canRun = false;
                }
                    break;
            }
        }
    }
}