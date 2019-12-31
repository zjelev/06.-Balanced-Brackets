using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(", ");

                Article article = new Article(command[0], command[1], command[2]);

                articles.Add(article);
            }

            string orderBy = Console.ReadLine();

            switch (orderBy)
            {
                case "title":
                    articles = articles.OrderBy(a => a.Title).ToList();
                    break;
                case "content":
                    articles = articles.OrderBy(a => a.Content).ToList();
                    break;
                case "author":
                    articles = articles.OrderBy(a => a.Author).ToList();
                    break;
                default:
                    break;
            }

            foreach (var article in articles)
            {
                Console.WriteLine(article);
            }
        }
    }

    class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        //public void Edit(string content)
        //{
        //    this.Content = content;
        //}

        //public void ChangeAuthor(string author)
        //{
        //    this.Author = author;
        //}

        //public void Rename(string title)
        //{
        //    this.Title = title;
        //}

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
