namespace _06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] value = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int evenSum = 0;
            int oddSum = 0;
            for(int i =0; i <value.Length;i++)
            {
                int currentValue = value[i];
                if (currentValue % 2 == 0)
                {
                    evenSum += currentValue;
                }
                else
                {
                    oddSum += currentValue;
                }
            }
            Console.WriteLine(evenSum - oddSum);
        }
    }
}
