using System;

namespace MyBlog
{
    public class BlogWrapper
    {
        private Blog blog;

        public BlogWrapper(Blog blog)
        {
            this.blog = blog;
        }

        public void AddCategory()
        {
            Category category = CategoryWrapper.CreateCategory();
            if (!blog.CategoryExists(category.GetName()))
            {
                blog.AddCategory(category);
            }
        }

        public void AddAuthor()
        {
            Author author = AuthorWrapper.CreateAuthor();
            if (!blog.AuthorExists(author.GetName(),author.GetSurname()))
            {
                blog.AddAuthor(author);
            }
        }
        public void AuthorInfo()
        {
            Console.Write("Zadejte jméno autora: ");
            string name = Console.ReadLine();
            Console.Write("Zadejte příjmení autora: ");
            string surname = Console.ReadLine();

            if (blog.AuthorExists(name,surname))
            {
                AuthorWrapper.PrintAuthorInfo(blog.GetAuthorByNameAndSurname(name.ToLower(), surname.ToLower()));
            }
            else
            {
                Console.WriteLine("Vámi hledaný autor není v naší databázi. Zkuste prosím jiného.");
            }

            Console.ReadKey();
        }

        

        public void OpenCategory()
        {
            Console.Write("Zadejte název kategorie: ");
            string name = Console.ReadLine();

            if (blog.CategoryExists(name))
            {
                CategoryWrapper categoryWrapper = new CategoryWrapper(blog.GetCategoryByName(name), blog);
                categoryWrapper.CategoryMenu();
            }
            else
            {
                Console.WriteLine("Vámi hledaná kategorie není v naší databázi. Zkuste prosím jinou.");
            }

            Console.ReadKey();
        }

        
    }
}