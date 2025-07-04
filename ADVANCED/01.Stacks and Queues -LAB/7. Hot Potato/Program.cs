namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> children = new Queue<string>(Console.ReadLine().Split());

            int tossCount = int.Parse(Console.ReadLine()); //на колко да изгарят децаята от играта
            int tosses = 0;

            while (children.Count> 1)
            {
                tosses++;
                string childWithPotato = children.Dequeue();

                if (tosses == tossCount)
                {
                    tosses = 0;
                    Console.WriteLine($"Removed {childWithPotato}");
                }
                else
                {
                    children.Enqueue(childWithPotato);
                }
            }
            Console.WriteLine($"Last is {children.Dequeue()}");
        }
    }
}
