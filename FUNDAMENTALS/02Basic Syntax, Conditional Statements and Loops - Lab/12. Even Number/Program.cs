using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _12._Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    if (number % 2 == 0)
                    {
                        int absoluteValue = Math.Abs(number);
                        Console.WriteLine($"The number is: {absoluteValue}");
                        break; // terminate the program
                    }
                    else
                    {
                        Console.WriteLine("Please write an even number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
    }
}
