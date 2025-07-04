
namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine($"{(Factorial(firstNumber) / Factorial(secondNumber)):f2}");

        }
            private static double Factorial(double numbers)
            {
                double result = numbers;

                for (double i = numbers - 1; i >= 1; i--)
                {
                    result *= i;
                }

                return result;
            }
    }
}
