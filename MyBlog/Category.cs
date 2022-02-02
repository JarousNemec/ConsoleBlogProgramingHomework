using System;
using System.Collections.Generic;

namespace MyBlog
{
    [Serializable]
    public class Category
    {
        private string name;
        private List<Article> articles;

        public Category(string name)
        {
            this.name = name;
            articles = new List<Article>();
        }

        public override string ToString()
        {
            return name;
        }

        public string GetName()
        {
            return name;
        }

        public void AddArticle(Article article)
        {
            articles.Add(article);
        }

        public List<Article> GetArticles()
        {
            return articles;
        }

        public bool ArticleExists(string name)
        {
            foreach (var article in articles)
            {
                if (article.GetName() == name)
                {
                    return true;
                }
            }

            return false;
        }
        public Article GetArticleByName(string name)
        {
            foreach (var article in articles)
            {
                if (article.GetName() == name)
                {
                    return article;
                }
            }

            return null;
        }
    }
}