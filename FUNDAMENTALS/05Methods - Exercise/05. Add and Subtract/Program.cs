
namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirtNum = int.Parse(Console.ReadLine());

            int result = Sum(firstNum, secondNum);
            result = Substract(result, thirtNum);

            Console.WriteLine(result);
        }

        static int Substract(int result, int thirtNum)
        {
            return result - thirtNum;
        }

        static int Sum(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
    }
}
