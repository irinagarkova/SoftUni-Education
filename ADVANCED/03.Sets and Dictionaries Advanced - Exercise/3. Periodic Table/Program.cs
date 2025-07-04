namespace _3._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> set = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] compounds = Console.ReadLine().Split().ToArray();
                foreach (var item in compounds)
                {
                    set.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ",set));
        }
    }
}
