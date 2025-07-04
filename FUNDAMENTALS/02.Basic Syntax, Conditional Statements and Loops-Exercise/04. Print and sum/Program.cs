namespace _04._Print_and_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = firstNum; i < secondNum; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine(secondNum);
            sum += secondNum;
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
