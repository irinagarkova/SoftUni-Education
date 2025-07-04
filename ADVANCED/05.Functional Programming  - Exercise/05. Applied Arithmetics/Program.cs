namespace _05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputNum = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            Func<int[], string, int[]> applyArithmetics
                = (numbers, operation) =>
                {
                    return operation == "add"
                    ? numbers.Select(x => x + 1).ToArray()
                    : operation == "multiply"
                    ? numbers.Select(x => x * 2).ToArray()
                    : numbers.Select(x => x - 1).ToArray();
                };

            while (command != "end")
            {
                if (command == "print")
                {
                    Console.WriteLine(string.Join(" ", inputNum));
                }
                else
                {
                    inputNum = applyArithmetics(inputNum, command);
                }
                command = Console.ReadLine();


            }
        }
    }
}
