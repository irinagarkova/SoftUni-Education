namespace _02._Articles
{
    internal partial class Program
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
    }
}
