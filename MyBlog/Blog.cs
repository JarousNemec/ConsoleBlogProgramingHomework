using System;
using System.Collections.Generic;

namespace MyBlog
{
    [Serializable]
    public class Blog
    {
        private List<Category> categories;
        private List<Author> authors;

        public Blog()
        {
            categories = new List<Category>();
            authors = new List<Author>();
        }

        public void AddAuthor(Author author)
        {
                authors.Add(author);
        }
        
        public void AddCategory(Category category)
        {
                categories.Add(category);
        }
        public List<Category> GetCategories()
        {
            return categories;
        }

        public List<Author> GetAuthors()
        {
            return authors;
        }

        public bool CategoryExists(string name)
        {
            foreach (var category in categories)
            {
                if (category.GetName() == name)
                {
                    return true;
                }
            }
            return false;
        }
        public bool AuthorExists(string name, string surname)
        {
            foreach (var author in authors)
            {
                if (author.GetName() == name && author.GetSurname() == surname)
                {
                    return true;
                }
            }
            return false;
        }
        
        public Category GetCategoryByName(string name)
        {
            foreach (var category in categories)
            {
                if (category.GetName().ToLower() == name.ToLower())
                {
                    return category;
                }
            }

            return null;
        }
        
        public Author GetAuthorByNameAndSurname(string name, string surname)
        {
            foreach (var author in authors)
            {
                if (author.GetName().ToLower() == name.ToLower() && author.GetSurname().ToLower() == surname)
                {
                    return author;
                }
            }

            return null;
        }
    }
}

//crud 
//c - create
//r - read
//u - update
//d - delete