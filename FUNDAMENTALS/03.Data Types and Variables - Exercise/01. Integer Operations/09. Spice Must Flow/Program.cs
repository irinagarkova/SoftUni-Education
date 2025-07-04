using System.Numerics;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine()); // начален добив
            int daysOfWork = 0; // колко дни е работила мината 
            int totalAmont = 0; //количество извлечена подправка

            while (startingYield >= 100)
            {
                totalAmont += startingYield;
                startingYield -= 10; //всеки ден пада добива с 10
                totalAmont -= 26; // консумация
                daysOfWork++;
            }
            totalAmont -= 26;
            totalAmont = Math.Max(totalAmont, 0);

            Console.WriteLine(daysOfWork);
            Console.WriteLine(totalAmont);
        }
    }
}
