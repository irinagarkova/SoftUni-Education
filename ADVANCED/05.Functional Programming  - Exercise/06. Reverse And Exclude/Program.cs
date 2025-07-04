namespace _06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputNum = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Reverse()
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            Func<int, int, bool> filter = (numbers, div)
                => numbers % div == 0;
            int[] result = inputNum.Where(x => !filter(x, n)).ToArray();
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
