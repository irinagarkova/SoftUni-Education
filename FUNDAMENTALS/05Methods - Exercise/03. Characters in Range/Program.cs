
namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main()
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            if (first > second)
            {
                char one = first;
                first = second;
                second = one;
            }
            AsciiToAccording(first, second);
        }

        private static void AsciiToAccording(char first, char second)
        {
            for (int i = first + 1; i < second; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
