namespace _2._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = numbers[0];
            int m = numbers[1];
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                firstSet.Add(currentNum);
            }
            for (int i = 0; i < m; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                secondSet.Add(currentNum);
            }
            foreach (var i in firstSet)
            {
                if (secondSet.Contains(i))
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}
