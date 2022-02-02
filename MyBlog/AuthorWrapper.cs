using System;
using System.Globalization;

namespace MyBlog
{
    public class AuthorWrapper
    {
        
        public static void PrintAuthorInfo(Author author)
        {
            Console.Clear();
            Console.WriteLine(author);
            Console.WriteLine("Informace o autorovi: " + author.GetInfo());
        }

        public static Author CreateAuthor()
        {
            Console.Clear();
            Console.Write("Zadejte jméno autora: ");
            string name = Console.ReadLine();
            Console.Write("Zadejte příjmení autora: ");
            string surname = Console.ReadLine();
            Console.Write("Zadejte popis autora: ");
            string text = Console.ReadLine();
            
            return new Author(name, surname, text);
        }
        
        public static Author CreateAuthorWithParameter(string name, string surname)
        {
            Console.Write("Zadejte popis autora: ");
            string text = Console.ReadLine();
            
            return new Author(name, surname, text);
        }
    }
}