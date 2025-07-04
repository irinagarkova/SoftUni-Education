namespace _02.Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] operations = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            int[] inputNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>();
            int elementsToEnqueue = operations[0];
            int elementsToDequeue = operations[1];
            int elementsToLookUp = operations[2];

            for (int i = 0; i < elementsToEnqueue; i++)
            {
                queue.Enqueue(inputNumbers[i]);
            }
            while (queue.Any () && elementsToDequeue >0)
            {
                queue.Dequeue();
                elementsToDequeue--;
            }
            if (!queue.Any())
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(elementsToLookUp))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());

            }
        }
    }
}
