using System;

namespace _11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            while (times < 10)
            {
                Console.WriteLine($"{firstNum} X {times} = {firstNum * times}");
                times ++;
            }
         
            do
            {
                Console.WriteLine($"{firstNum} X {times} = {firstNum * times}");
                times++;

            } while (times <= 10);

        }
    }
}
