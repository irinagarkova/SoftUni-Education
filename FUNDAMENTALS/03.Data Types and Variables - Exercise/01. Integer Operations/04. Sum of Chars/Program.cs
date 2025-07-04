namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nCount = int.Parse(Console.ReadLine());
            int totalSum = 0;
            //Фор цикъл за да се завъртят всички букви)
            for (int i = 0; i < nCount; i++)
            {
                char c = char.Parse(Console.ReadLine());
                totalSum += c;
            }
            Console.WriteLine($"The sum equals: {totalSum}");

        }
    }
}
