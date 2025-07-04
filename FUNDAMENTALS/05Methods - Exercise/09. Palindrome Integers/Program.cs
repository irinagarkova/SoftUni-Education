
namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                bool IsPalindrome = IsNumberPalindrome(input);
                Console.WriteLine(IsPalindrome);
            }
        }
        private static bool IsNumberPalindrome(string input)
        {
            // AKO примерно числото е 12321
            string firstHalf = input.Substring(0, input.Length / 2); //ще остане 12
             //SUBSTRING ще вземе първата половина на стринга 
            char[] charArr = input.ToCharArray();
            // ще стане масив със стойности: ["1", "2" , "3" , "2" , "1"]
            Array.Reverse(charArr); //обръщане на масив
            string temp = new string(charArr);
            //ще направи стирнг "12321"
            string lastHalf = temp.Substring(0, temp.Length / 2);
            //ще остане 12
             
            return firstHalf == lastHalf;
        }
    }
}
