namespace _07._Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, int, bool> func = (name, length)
                => name.Length <= length;

            int n = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split().Where(x => func(x, n)).ToArray();

            Console.WriteLine(string.Join(Environment.NewLine,names));
        }
    }
}
