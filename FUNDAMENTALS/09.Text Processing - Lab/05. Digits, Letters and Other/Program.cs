﻿namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string letters= "";
            string numbers = "";
            string other = ""; 


            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                if (char.IsDigit(currentChar))
                {
                    numbers += currentChar;
                }
                else if (char.IsLetter(currentChar))
                {
                    letters += currentChar;
                }
                else
                {
                    other += currentChar;
                }
            }
            Console.WriteLine(numbers);
            Console.WriteLine(letters);
            Console.WriteLine(other);
        }
    }
}
