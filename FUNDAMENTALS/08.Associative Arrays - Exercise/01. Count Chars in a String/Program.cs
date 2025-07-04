using System;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> charOccurrences = new Dictionary<char, int>();
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char character = input[i];

                if (character == ' ')
                {
                    continue;
                }
                //има ли такъв клуч? ако го няма го добави
                if (!charOccurrences.ContainsKey(character)) //проверяваме дали го НЯМА// АКО НЕ СЪДЪРЖА КЛЮЧА
                {
                   charOccurrences.Add(character, 0);
                }

                charOccurrences[character]++; 
            }

            foreach (KeyValuePair<char, int> charPear in charOccurrences)
            {
                char character = charPear.Key; //всима ключа
                int occurrence = charPear.Value;// взима стойноста
                Console.WriteLine($"{character} -> {occurrence}");    
            }
        }
    }
}
