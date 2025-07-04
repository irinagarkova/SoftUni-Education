using System.Net.Http.Headers;
using System.Numerics;

namespace _05._Orders
{
    internal class Program
    {


        static void Main()
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            decimal price = 0;
            switch (product)
            {
                // "coffee", "water", "coke", "snacks" 
                case "coffee": price = 1.50m; break;
                case "water": price = 1.00m; break;
                case "coke": price = 1.40m; break;
                case "snacks": price = 2.00m; break;
            }
            Console.WriteLine(quantity*price);
        }
       
    
    }
}
