using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersOfSnowballs = int.Parse(Console.ReadLine());
                double bestSnow = 0;
                double bestTime= 0;
                double bestQuality = 0;
                BigInteger bestValue = 0;

            for (int i = 0; i < numbersOfSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());  // количество сняг
                int snowballTime = int.Parse(Console.ReadLine()); //време
                int snowballQuality = int.Parse(Console.ReadLine()); // качество 

               BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime),snowballQuality); // на степен
                if (bestValue < snowballValue)
                {
                    bestValue = snowballValue;
                    bestSnow = snowballSnow;
                    bestTime = snowballTime;
                    bestQuality = snowballQuality;
                }

            }
               Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");



        }
    }
}
