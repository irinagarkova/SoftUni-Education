namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringsArrays = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries);

            List<string> symbols = ExtractSymbols(stringsArrays);
            Console.WriteLine(string.Join(" ", symbols));
        }

        private static List<string> ExtractSymbols(string[] stringsArrays)
        {
            List<string> result = new List<string>();
            // тук трябва да получим елементите като масиви и да си съберем в result
            for (int  i = stringsArrays.Length - 1;  i >= 0;  i--)
            {
                string[] array = stringsArrays[i]
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries).
                    ToArray();

                result.AddRange(array);
            }
            
            return result;
        }
    }
}
