namespace _01.Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] operations = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int [] inputElements = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>();
            int elementsToPush = operations[0];
            int elementsToPop = operations[1];
            int elementsToLookUp = operations[2];

            for (int i = 0; i < elementsToPush; i++)
            {
                stack.Push(inputElements[i]);
            }
            while (stack.Count > 0 && elementsToPop > 0)
            {
                stack.Pop();
                elementsToPop--;
            }
            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(elementsToLookUp))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());

            }

        }
    }
}
 