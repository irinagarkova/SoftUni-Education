namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synomyn = Console.ReadLine();

                if (!result.ContainsKey(word)) //ако го няма го добавяме
                {
                    result[word] = new List<string>();

                }
                result[word].Add(synomyn);
            }
            foreach (KeyValuePair<string,List<string>> kvp in result)
            {
                Console.WriteLine($"{kvp.Key} - {string.Join(", ",kvp.Value)}");
            }
        }
    }
}
