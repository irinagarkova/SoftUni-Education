using System.Text.RegularExpressions;
namespace _03._Match_Dates
{
    // 13/Jul/1928, 10-Nov-1934, , 01/Jan-1951,f 25.Dec.1937 23/09/1973, 1/Feb/2016 
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<date>\d{2})(?<separator>\.|\-|\/)(?<month>[A-Z][a-z]{2})(\k<separator>)(?<year>\d{4})";
            string input = Console.ReadLine();

            var matches = Regex.Matches(input, pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups["date"]}, Month: {match.Groups["month"]}, Year: {match.Groups["year"]}");

            }
        }
    }
}
