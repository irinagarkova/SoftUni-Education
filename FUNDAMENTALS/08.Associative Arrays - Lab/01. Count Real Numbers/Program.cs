using System.Xml.Linq;

namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] inputNum = Console.ReadLine()
             .Split()
             .Select(double.Parse)
             .ToArray();

            SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();

            for (int i = 0; i < inputNum.Length; i++)
            {
                double currentNum = inputNum[i];
                if (!numbers.ContainsKey(currentNum))
                {
                    numbers.Add(currentNum, 0);
                }
                numbers[currentNum]++;
            }

            foreach (KeyValuePair <double,int> kvp in numbers)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
