using System.Net.Http.Headers;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int minNumber = MinInteger(firstNum, secondNum);
            minNumber = MinInteger(minNumber, thirdNum);
            Console.WriteLine(minNumber);
        }

        private static int MinInteger(int firstNum, int secondNum)
        {
            if (firstNum < secondNum)
            {
                return firstNum;
            }
            else
            {
                return secondNum;
            }
        }
    }
}
