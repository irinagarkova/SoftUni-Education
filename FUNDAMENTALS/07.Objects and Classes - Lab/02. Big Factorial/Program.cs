﻿using System.Numerics;

namespace _02._Big_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger f = 1;
            for (int i = 2; i <= n; i++)
                f *= i;
            Console.WriteLine(f);
        }
    }
}
