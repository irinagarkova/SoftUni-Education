namespace FoodShortage
{
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, IBuyer> buyers = ReadBuyers(n);
            string name = Console.ReadLine();
            while (name != "End")
            {
                if (buyers.ContainsKey(name)) 
                    buyers[name].BuyFood();

                name = Console.ReadLine();
            }

            int totalFood = buyers.Values.Sum(x => x.Food);
            Console.WriteLine(totalFood);

        }
        private static Dictionary<string, IBuyer> ReadBuyers(int n)
        {
            Dictionary<string, IBuyer> result = new Dictionary<string, IBuyer>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();
                string name = data[0];

                if (data.Length == 4) result[name] = new Citizen(name, int.Parse(data[1]), data[2], data[3]);
                else if (data.Length == 3) result[name] = new Rebel(name, int.Parse(data[1]), data[2]);
            }
            return result;

        }
    }
}
