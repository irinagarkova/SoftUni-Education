﻿namespace _10._Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());
            if (letter >= 'A' && letter <= 'Z')
            {
                Console.WriteLine("upper-case");
            }
            else if (letter >= 'a' && letter <= 'z')
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
