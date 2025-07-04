namespace _05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstChar = int.Parse(Console.ReadLine());
            int endChar = int.Parse(Console.ReadLine());

            for (int i = firstChar; i <= endChar; i ++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
