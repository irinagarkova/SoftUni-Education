using System;
using System.Linq;
namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] doubleNumbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            int[] roundedNums = new int[doubleNumbers.Length];
            for (int i = 0; i < doubleNumbers.Length; i++)
            {
                roundedNums[i] = (int)Math.Round(doubleNumbers[i], MidpointRounding.AwayFromZero);
            }
            for (int i = 0; i < doubleNumbers.Length; i++)
            {
                Console.WriteLine($"{doubleNumbers[i]} => {roundedNums[i]}");
            }
        }
    }
}
