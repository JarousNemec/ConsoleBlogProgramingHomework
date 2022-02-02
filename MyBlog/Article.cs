using System;

namespace MyBlog
{
    [Serializable]
    public class Article
    {
        private Author author;
        private string name;
        private string text;
        private DateTime publicationDate;

        public Article(string name, Author author, string text, DateTime publicationDate)
        {
            this.name = name;
            this.author = author;
            this.text = text;
            this.publicationDate = publicationDate;
        }

        public override string ToString()
        {
            return name;
        }

        public string GetName()
        {
            return name;
        }

        public string GetInfo()
        {
            return $"Název článku: {name}\nAutor: {author}\nDatum: {publicationDate.Date}\n\n{text}";
        }
    }
}