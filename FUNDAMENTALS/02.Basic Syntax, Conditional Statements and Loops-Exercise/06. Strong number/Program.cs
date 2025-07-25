﻿namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberCopy = number;
            int factorialSum = 0;

            while (numberCopy > 0)
            {
                int digit = numberCopy % 10;
                numberCopy /= 10;

                int factorial = 1;
                for (int i = 1; i <= digit; i++)
                {
                    factorial *= i;
                }

                factorialSum += factorial;
            }

            int isStrongNumber = factorialSum;
            if (isStrongNumber == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
          

        }
    }
}
