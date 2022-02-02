using System;
using System.Security.Cryptography;

namespace MyBlog
{
    [Serializable]
    public class Author
    {
        private string name;
        private string surname;
        private string info;

        public Author(string name, string surname, string info)
        {
            this.name = name;
            this.surname = surname;
            this.info = info;
        }

        public override string ToString()
        {
            return $"{name} {surname}";
        }

        public string GetName()
        {
            return name;
        }

        public string GetSurname()
        {
            return surname;
        }

        public string GetInfo()
        {
            return info;
        }
    }
}