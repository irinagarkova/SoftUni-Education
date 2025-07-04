
namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = ReadListOfIntegers();
            List<int> secondList = ReadListOfIntegers();

            List<int> result = new List<int>();
            int greaterCount = Math.Max(firstList.Count, secondList.Count);

            for (int i = 0; i < greaterCount; i++)
            {
                if (i < firstList.Count)
                {
                  result.Add(firstList[i]);

                }
                if (i < secondList.Count)
                { 
                  result.Add(secondList[i]);
                }
            }
            PrintResult(result);
        }

        static List<int> ReadListOfIntegers()
        {
            return Console.ReadLine().Split().Select(int.Parse).ToList();
        }
        static void PrintResult(List <int> numbers, string separator = " ")
        {
            Console.WriteLine(string.Join(separator,numbers));
        }
      
    }
}
