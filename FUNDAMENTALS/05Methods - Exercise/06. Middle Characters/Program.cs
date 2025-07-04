namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintMiddleCharacter(input);
        }
        static void PrintMiddleCharacter(string input)
        {
            int length = input.Length;
            int middleIndex = length / 2;

            if (length % 2 == 0) // Ако дължината на стринга е четна
            {
                // Изпечатване на двата средни символа
                Console.WriteLine(input.Substring(middleIndex - 1, 2));
            }
            else // Ако дължината на стринга е нечетна
            {
                
                Console.WriteLine(input[middleIndex]);
            }
        }
    }
}
