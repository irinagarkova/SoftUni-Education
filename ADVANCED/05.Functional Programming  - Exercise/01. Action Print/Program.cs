namespace _01._Action_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();

            Action<string[]> printNames = allNames
                => Console.WriteLine(string.Join(Environment.NewLine, names)); //нов ред

            printNames(names);
        }
    }
}
