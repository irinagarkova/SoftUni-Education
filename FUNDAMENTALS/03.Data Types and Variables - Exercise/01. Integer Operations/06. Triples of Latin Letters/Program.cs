namespace _06._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lettersCount = int.Parse(Console.ReadLine());
            int startChar = 97; // 'a'
            int endChar = startChar + lettersCount; //97 + 4;

            for (int firstChar = startChar; firstChar < endChar; firstChar++)
            {
                for (int secondChar = startChar; secondChar < endChar; secondChar++)
                {
                    for (int thirdChar = startChar; thirdChar < endChar; thirdChar++)
                    {
                        Console.WriteLine($"{(char)firstChar}{(char)secondChar}{(char)thirdChar}");
                    }
                }
            }
        }
    }
}
