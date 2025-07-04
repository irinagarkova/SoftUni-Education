using System.Runtime.CompilerServices;

namespace _04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine()
                .Split(" ")
                .ToArray();

            for (int i =0; i <values.Length /2; i++) //делим на 2 защото имаме 4 елемента,
            {
                string firstElement = values[i];
                string lastElement = values[values.Length - 1 - i]; //формула за взимане на вски един елемент

                values[i] = lastElement;
                values[values.Length - 1 - i] = firstElement;
            }
            Console.WriteLine(string.Join(" ", values));
        }
    }
}
