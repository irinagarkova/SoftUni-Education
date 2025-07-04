
namespace _05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = ReadListOfIntegers();
            List<int> positiveNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= 0)
                {
                positiveNumbers.Add(numbers[i]);
                    
                }
            }
            if (positiveNumbers.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }
            positiveNumbers.Reverse();
            PrintResult(positiveNumbers);
        }

        static void PrintResult(List<int> numbers, string separator = " ")
        {
            Console.WriteLine(string.Join(separator, numbers));
        }
        static List<int> ReadListOfIntegers()
        {
            return Console.ReadLine().Split().Select(int.Parse).ToList();
        }
    }
}
