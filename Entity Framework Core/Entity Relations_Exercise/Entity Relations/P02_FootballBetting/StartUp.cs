using P02_FootballBetting.Data;
using System.Linq.Expressions;

namespace P02_FootballBetting
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            try
            {
                using FootballBettingContext dbContext = new FootballBettingContext();
                dbContext.Database.EnsureDeleted();
                dbContext.Database.EnsureCreated();

                Console.WriteLine("DONE");
            }
            catch (Exception e)
            {
                Console.WriteLine("WRONG");
                Console.WriteLine(e.Message);
                
            }
        }
    }
}
