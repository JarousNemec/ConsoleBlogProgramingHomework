using System;

namespace MyBlog
{
    public class CategoryWrapper
    {
        private Category category;
        private Blog blog;

        public CategoryWrapper(Category category, Blog blog)
        {
            this.blog = blog;
            this.category = category;
        }

        public static Category CreateCategory()
        {
            Console.Clear();
            Console.Write("Zadejte jméno kategorie: ");
            string name = Console.ReadLine();

            return new Category(name);
        }

        public void CategoryMenu()
        {
            PrintCategoryMenu();
            HandleInput();
        }

        public void AddArticle()
        {
            ArticleWrapper.CreateArticle(blog);
        }

        private void PrintCategoryMenu()
        {
            Console.Clear();
            Console.WriteLine(category);
            if (category.GetArticles().Count != 0)
            {
                Console.WriteLine("Články: ");
                foreach (var article in category.GetArticles())
                {
                    Console.WriteLine(article);
                }

                Console.WriteLine("Možnosti: ");
                Console.WriteLine("1) Přidat článek");
                Console.WriteLine("2) Otevřít článek");
            }
            else
            {
                Console.WriteLine("Tato kategorie zatím neobsahuje žádné články.");
                Console.WriteLine("Možnosti: ");
                Console.WriteLine("1) Přidat článek");
            }
        }

        private const string ADD_ARTICLE = "1";
        private const string OPEN_ARTICLE = "2";
        private void HandleInput()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case ADD_ARTICLE:
                {
                    var article = ArticleWrapper.CreateArticle(blog);
                    category.AddArticle(article);
                }
                    break;

                case OPEN_ARTICLE:
                {
                    ArticleWrapper.DisplayArticleByName(category);
                }
                    break;
            }
        }
    }
}