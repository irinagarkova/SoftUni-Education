
namespace ConsoleApp1
{
    internal class Program
    {

        class Article
        {

            public Article(string tittle, string content, string author)
            {
                this.Tittle = tittle;
                this.Content = content;
                this.Author = author;
            }
            public string Tittle { get; set; }

            public string Content { get; set; }

            public string Author { get; set; }
            public override string ToString()
            {
                return $"{Tittle} - {Content}: {Author}";
            }
        }

        static void Main()
        {
            List<Article> articles = new List<Article>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {

               string[] articleStr = Console.ReadLine().Split(", ");
            Article article = new Article(articleStr[0],
                articleStr[1],
                articleStr[2]);

                articles.Add(article);
            }
            foreach (Article article in articles)
            {
               Console.WriteLine(article.ToString());   
            }
        }
    }
}
    