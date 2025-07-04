namespace _5._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            SortedDictionary<char, int> charOccurences = new SortedDictionary<char, int>();

            foreach (var currentCh in text)
            {
                if (!charOccurences.ContainsKey(currentCh))
                {
                    charOccurences.Add(currentCh, 0);
                
                }
                charOccurences[currentCh]++;
            }
            foreach (var (sym, occ) in charOccurences)
            {
                Console.WriteLine($"{sym}: {occ} time/s");
            }
        }
    }
}
