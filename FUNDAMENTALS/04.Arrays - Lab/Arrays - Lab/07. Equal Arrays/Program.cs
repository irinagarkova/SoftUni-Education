using System;

namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] secondArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            if (firstArray.Length != secondArray.Length)
            {
                Console.WriteLine($"Arrays are not identical. Found difference at 0 index");
                return;
            }
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
            }
            int sum = 0;
            foreach (var currentNum in secondArray)
            {
                sum += currentNum;
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
