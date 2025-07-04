namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string currentWord;
            while ((currentWord = Console.ReadLine()) != "end")
            {
                string reversedWord = new string(currentWord.Reverse().ToArray());
                Console.WriteLine($"{currentWord} = {reversedWord}");
            }

        }
    }
}
