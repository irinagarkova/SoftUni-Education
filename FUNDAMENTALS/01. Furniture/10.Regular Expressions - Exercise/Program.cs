using System;
using System.Text.RegularExpressions;

namespace _10.Regular_Expressions___Exercise
{
    internal class Program
    {
        class Furniture
        {
           public string Name { get; set; }
           public decimal Price { get; set; }
           public int Quantity { get; set; }
          public decimal Total => Price * Quantity;
        }
        static void Main(string[] args)
        {

            List<Furniture> furnitures = new List<Furniture>();

            string pattern = @">>(?<Name>[A-Za-z]+)<<(?<Price>\d+\.\d*|\d+)!(?<Qunatity>\d+)";

            string input;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                foreach (Match match in Regex.Matches(input, pattern))
                {
                    Furniture furniture = new Furniture();
                    furniture.Name = match.Groups["Name"].Value;
                    furniture.Price = decimal.Parse(match.Groups["Price"].Value);
                    furniture.Quantity = int.Parse(match.Groups["Qunatity"].Value);

                    furnitures.Add(furniture);
                }
            }
            Console.WriteLine("Bought furniture:");
            decimal totalSpend = 0;
            foreach (Furniture furniture in furnitures)
            {
                Console.WriteLine(furniture.Name);
                totalSpend += furniture.Total;
            }
            Console.WriteLine($"Total money spend: {totalSpend:F2}");


        }
    }
}
