namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> clothes = new Stack<int>(values);

            int currentRackCapaqcity = 0;
            int box =1;

            while (clothes.Any())
            {
                int currentClothes = clothes.Pop();
                if (currentRackCapaqcity + currentClothes <= rackCapacity)
                {
                    currentRackCapaqcity += currentClothes;
                }
                else
                {
                    currentRackCapaqcity = currentClothes;
                    box++;
                }
            }
            Console.WriteLine(box);
        }
    }
}
