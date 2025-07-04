namespace _00111
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> packages = new(Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse));

            Queue<int> couriers = new(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            int totalWeigth = 0;

            while (packages.Count > 0 && couriers.Count > 0)
            {
                int currentPack = packages.Pop();
                int currentCourier = couriers.Dequeue();

                if (currentCourier >= currentPack)
                {
                    if (currentCourier > 0)
                    {
                        currentCourier = currentCourier - 2 * currentPack;
                        couriers.Enqueue(currentCourier);
                    }
                    else //0
                    {
                        couriers.Dequeue();
                    
                    }
                    totalWeigth += currentPack;
                
                }
                else if (currentCourier < currentPack)
                {
                    currentPack -= currentCourier;
                    //currentPack += packages.Pop();
                    packages.Push(currentPack);
                }


            }

            if (packages.Count == 0 && couriers.Count == 0)
            {
                Console.WriteLine($"Total weight: {totalWeigth} kg");
                Console.WriteLine("Congratulations, all packages were delivered successfully by the couriers today.");
            }
            else if (packages.Count > 0 && couriers.Count == 0)
            {
                Console.WriteLine($"Total weight: {totalWeigth} kg");
                Console.WriteLine($"Unfortunately, there are no more available couriers to deliver the following packages: {string.Join(", ", packages)}");
            }
            else if (packages.Count == 0 && couriers.Count > 0)
            {
                Console.WriteLine($"Couriers are still on duty: {string.Join(", ", couriers)} but there are no more packages to deliver.");
            }
        }
    }
}
