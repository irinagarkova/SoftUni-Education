namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();
            
            Random random = new Random();
            for (int i = 0; i < text.Length; i++)
            {
                int randomIndex = random.Next(text.Length);

                string word = text[i];
                string randomIndexWord = text[randomIndex];
                text[i] = randomIndexWord;
                text[randomIndex] = word;
            
            }
            Console.WriteLine(string.Join(Environment.NewLine, text ));
        }
    }
}
