namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split()
                .Select(x => x.ToLower())
                .ToArray();

            Dictionary<string, int> result = new Dictionary<string, int>();
           
            foreach (var item in input)
            {
                if (!result.ContainsKey(item))
                {
                    result[item] = 0;
                }
                result[item]++;
            }

            foreach (KeyValuePair<string, int> kvp in result)
            {
                if (kvp.Value % 2 == 1)
                { 
                  Console.Write($"{kvp.Key} ");
                }
            }

        }
    }
}
