using System.Text;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder result = new StringBuilder(capacity: text.Length);
            for(int i = 0; i<text.Length;i++)
            {
                char subsitute = (char)(text[i] + 3);
                result.Append(subsitute);
            }
            Console.WriteLine(result.ToString());
        }
    }
}
