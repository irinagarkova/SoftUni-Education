﻿namespace _08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int givenNum = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                { 
                    if (numbers[i] + numbers[j] == givenNum)
                    {

                        Console.WriteLine($"{numbers[i]} {numbers[j]}");
                      
                    }
                } 

            }


        }
    }
}
