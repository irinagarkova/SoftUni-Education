namespace _02._Articles
{
    internal class Program
    {
        class Article
        {

            public Article(string tittle, string content, string author)
            {
                Tittle = tittle;
                Content = content;
                Author = author;
            }
            public string Tittle { get; set; }

            public string Content { get; set; }

            public string Author { get; set; }

            public void EditContent(string newContent)
            {
                Content = newContent;
            }
            public void ChangeAuthor(string newAuthor)
            {
                Author = newAuthor;
            }
            public void Rename(string newTitle)
            {
                Tittle = newTitle;
            }
            public override string ToString()
            {
                return $"{Tittle} - {Content}: {Author}";
            }

        }
        static void Main(string[] args)
        {
            string[] articleStr = Console.ReadLine().Split(", ");
            Article article = new Article(articleStr[0], articleStr[1], articleStr[2]);
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                articleStr = Console.ReadLine().Split(": ");

                switch (articleStr[0])
                {
                    case "Edit":
                        article.EditContent(articleStr[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(articleStr[1]);
                        break;
                    case "Rename":
                        article.Rename(articleStr[1]);
                        break;
                }
                Console.WriteLine(article.ToString);
            }
        }
    }
}
