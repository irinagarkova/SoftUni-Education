namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();


            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                int command = input[0];
                if (command == 1)
                {
                    stack.Push(input[1]);
                }
                else if (command == 2 && stack.Any()) //командата 2 ли е И има ли цифри в Стека
                {
                    stack.Pop();
                }
                else if (command == 3 && stack.Any())
                {
                    Console.WriteLine(stack.Max());
                }
                else if (command == 4 && stack.Any())
                {
                    Console.WriteLine(stack.Min());
                }
            }
                Console.WriteLine(string.Join(", ",stack));
        }
    }
}
