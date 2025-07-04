namespace _04._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(`,
                Console.ReadLine()
                .Split()
                .Where(x => x.Length % 2 == 0)
                .ToArray()));
        }
    }
}
