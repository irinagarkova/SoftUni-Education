using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int currentNum = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                if ((sum == 5) || (sum == 7) || (sum == 11))
                {
                    Console.WriteLine($"{currentNum} -> True");
                }
                else
                {
                    Console.WriteLine($"{currentNum} -> False");
                }
                sum = 0;
                i = currentNum;
            }
            
        }
    }
}
