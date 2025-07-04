namespace _06.Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            Dictionary<string, Dictionary<string, int>> wardrobe =
                new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                //Blue -> dress,jeans,hat
                string[] input = Console.ReadLine()
                  .Split(" -> ");
                string color = input[0];
                string[] clothes = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                foreach (var item in clothes)
                {
                    if (!wardrobe[color].ContainsKey(item))
                    {
                        wardrobe[color].Add(item, 0);
                    }
                    wardrobe[color][item] += 1;
                }
            }
            string[] lookUp = Console.ReadLine().Split();
            foreach (var (color, clothes) in wardrobe)
            {
                Console.WriteLine($"{color} clothes:");

                foreach (var (item, count) in clothes)
                {
                    string outputValue = $"* {item} - {count}";

                    if (color == lookUp[0] && item == lookUp[1])
                    {
                        outputValue += " (found!)";
                    }

                    Console.WriteLine(outputValue);
                }
            }
        }
    }
}
