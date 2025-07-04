using System.Collections.Generic;
using System.Xml.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] passengers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
            //Всяко число е броя на пътниците във вагона

            int maxPassangers = int.Parse(Console.ReadLine());
            List<int> wagons = new List<int>(passengers);
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input.Split();
                if (arguments[0] == "Add")
                {
                    wagons.Add(int.Parse(arguments[1]));
                }
                else
                {
                    int element = int.Parse(arguments[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + element <= maxPassangers)
                        {
                            wagons[i] += element;
                            break;
                        }
                    }
                }

            }
                Console.WriteLine(string.Join(" ", wagons));
        }
    }
}



