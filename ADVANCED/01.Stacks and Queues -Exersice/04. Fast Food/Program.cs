namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] inputOrderQuantities = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> orders = new Queue<int>(inputOrderQuantities); //ДИРЕКТНО ПЪЛНИМ КОЛЕКЦИЯТА
            Console.WriteLine(orders.Max());
            while (orders.Count > 0 && foodQuantity > 0)
            {
                if (foodQuantity - orders.Peek() >= 0)
                {
                    int currentOrder = orders.Dequeue();
                    foodQuantity -= currentOrder; //проверяваяме дали има още поръчки и намаляме
                }
                else
                {
                    break;
                }
            }
            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ",orders)}");
            }
        }
    }
}
