namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] symbols = Console.ReadLine().Split();

            int bestCount = 0;
            string bestCountSym = "";

            for (int i = symbols.Length - 1;  i >= 0;  i--)
            {
                int count = 1;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (symbols[i] == symbols[j])
                    {
                        count++;
                        if (bestCount <= count)
                        {
                            bestCount = count;
                            bestCountSym = symbols[i];
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                
            }

            string[] result = new string[bestCount];
            Array.Fill(result, bestCountSym, 0, bestCount);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
