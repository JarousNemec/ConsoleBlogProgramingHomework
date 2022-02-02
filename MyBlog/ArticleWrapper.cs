using System;

namespace MyBlog
{
    public class ArticleWrapper
    {
        public static Article CreateArticle(Blog blog)
        {
            Console.Write("Zadejte název článku: ");
            string name = Console.ReadLine();
            Console.Write("Zadejte jméno autora: ");
            string authorName = Console.ReadLine();
            Console.Write("Zadejte příjmení autora: ");
            string surname = Console.ReadLine();
            Author author;
            if (blog.AuthorExists(authorName, surname))
            {
                author = blog.GetAuthorByNameAndSurname(authorName, surname);
            }
            else
            {
                Console.WriteLine("Autor nenalezen zakládáme nového");
                author = AuthorWrapper.CreateAuthorWithParameter(authorName,surname);
                blog.AddAuthor(author);
            }

            Console.WriteLine("Vložte text článku: ");
            string text = Console.ReadLine();
            return new Article(name, author, text, DateTime.Today);
        }

        public static void DisplayArticleByName(Category category)
        {
            Console.WriteLine("Zadejte jméno článku: ");
            string name = Console.ReadLine();
            if (category.ArticleExists(name))
            {
                Console.Clear();
                Console.WriteLine(category.GetArticleByName(name).GetInfo());
            }
            else
            {
                Console.WriteLine("Článek neexistuje");
            }
        }
    }
}