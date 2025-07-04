namespace _05._Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] value = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            for(int i =0; i <value.Length;i++)
            {
                int currentValue = value[i];
                    if (currentValue % 2 == 0)
                {
                    sum += currentValue;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
