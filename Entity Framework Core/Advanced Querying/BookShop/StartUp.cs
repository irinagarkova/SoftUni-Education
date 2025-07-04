namespace BookShop
{
    using BookShop.Models;
    using BookShop.Models.Enums;
    using Data;
    using Initializer;
    using Microsoft.EntityFrameworkCore;
    using System.Globalization;
    using System.Reflection.Metadata.Ecma335;
    using System.Text;
    using System.Threading.Channels;
    using static BookShop.Common.EntityValidationConstants;

    public class StartUp
    {
        public static void Main()
        {
            using var dbContext = new BookShopContext();
        //  DbInitializer.ResetDatabase(dbContext);

            using var context = new BookShopContext();
            string date = Console.ReadLine();
            string result = GetBooksReleasedBefore(context, date);
            Console.WriteLine(result);

            // IncreasePrices(dbContext);

        }

        //Problem 2
        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            string result = String.Empty;

            bool isEnumValid = Enum
                .TryParse(command, true, out AgeRestriction ageRestriction);
            if (!isEnumValid)
            {
                return result;
            }

            string[] bookTitles = context
                .Books
                .Where(b => b.AgeRestriction == ageRestriction)
                .OrderBy(b => b.Title)
                .Select(b => b.Title)
                .ToArray();

            result = String.Join(Environment.NewLine, bookTitles);

            return result;
        }


        //Problem 3
        public static string GetGoldenBooks(BookShopContext context)
        {
            string[] titles = context.Books
                .Where(b => b.EditionType == EditionType.Gold && b.Copies < 5000)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToArray();

            return String.Join(Environment.NewLine, titles);
        }

        //Problem 4
        public static string GetBooksByPrice(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();
            var books = context.Books
                  .Where(b => b.Price > 40)
                 .OrderByDescending(b => b.Price)
              .Select(b => new
              {
                  b.Title,
                  b.Price
              })
              .ToArray();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} - ${book.Price:F2}");
            }

            return sb.ToString().Trim();

        }

        //Problem 5
        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            var books = context.Books
                .Where(b => b.ReleaseDate.HasValue && b.ReleaseDate.Value.Year != year)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToArray();

            return string.Join(Environment.NewLine, books);
        }

        //Problem 6
        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            string[] searchCategories = input
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(c => c.ToLowerInvariant())
                .ToArray();

            //Bulk solution
            string[] bookTitles = context.Books
                // .Include(b=>b.BookCategories)
                //.ThenInclude(bc => bc.Category)
                .Where(b => b.BookCategories
                .Any(bc => searchCategories.Contains(bc.Category.Name.ToLower())))
                .OrderBy(b => b.Title)
                .Select(b => b.Title)
                .ToArray();

            return String.Join(Environment.NewLine, bookTitles);
        }

        //Problem 7
        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            DateTime targetDate = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var books = context.Books
                .Where(b => b.ReleaseDate.HasValue && b.ReleaseDate.Value < targetDate)
                .OrderByDescending(b => b.ReleaseDate)
                .Select(b => new
                {
                    b.Title,
                    b.EditionType,
                    b.Price

                })
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} - {book.EditionType} - ${book.Price:F2}");
            }

            return sb.ToString().TrimEnd();
        }
    
        //Problem 8 
        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            StringBuilder sb = new StringBuilder();
            var authors = context.Authors
                 .Where(a => a.FirstName != null && a.FirstName.EndsWith(input))
                 .Select(a => new
                 {
                     a.FirstName,
                     a.LastName
                  })
                .OrderBy(a => a.FirstName)
                .ThenBy(a => a.LastName)
                .ToArray();

            foreach (var author in authors)
            {
                sb.AppendLine($"{author.FirstName} {author.LastName}");
            }

            return sb.ToString().Trim();
        }

        //Problem 9

        //Problem 10

        //Problem 11

        //Problem 12
        public static string CountCopiesByAuthor(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();
            var authorCopies = context.Authors
                .Include(a => a.Books)
                .Select(a => new
                {
                    a.FirstName,
                    a.LastName,
                    TotalCopies = a.Books.Sum(b => b.Copies)
                })
                .OrderByDescending(a => a.TotalCopies)
                .ToArray();

            foreach (var author in authorCopies)
            {
                sb.AppendLine($"{author.FirstName} {author.LastName} - {author.TotalCopies}");
            }
            return sb.ToString().TrimEnd();

        }

        //Problem 13
        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();
            var categoriesProfit = context.Categories
                .Include(c => c.CategoryBooks)
                .ThenInclude(cb => cb.Book)
                .Select(c => new
                {
                    c.Name,
                    TotalProfit = c
                    .CategoryBooks
                    .Sum(cb => cb.Book.Price * cb.Book.Copies)

                })
                .OrderByDescending(c => c.TotalProfit)
                .ThenBy(c => c.Name)
                .ToArray();

            foreach (var category in categoriesProfit)
            {
                sb.AppendLine($"{category.Name} ${category.TotalProfit.ToString("F2")}");
            }

            return sb.ToString().TrimEnd();
        }

        //Problem 14

        //Problem 15
        public static void IncreasePrices(BookShopContext context) 
        {
            const int bookPriceIncrement = 5;
            IQueryable<Models.Book> booksToModify = context.Books
                  .Where(b => b.ReleaseDate.HasValue && b.ReleaseDate.Value.Year < 2010);

            foreach (var book in booksToModify)
            {
                book.Price += bookPriceIncrement;
            }
            //Up to here, no SQL Query will be executed! SaveChanges() will persist the changes ot the attached entitties.
            context.SaveChanges();
        }
    }
}


