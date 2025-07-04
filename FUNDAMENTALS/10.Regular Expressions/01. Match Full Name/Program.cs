using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<firstName>[A-Z][a-z]+) (?<lastName>[A-Z][a-z]+)";
            string input = Console.ReadLine();

            var matches = Regex.Matches(input, pattern);
            Console.WriteLine(string.Join(" ", matches.Select(x => x.Groups[0])));
           
        }
    }
}
