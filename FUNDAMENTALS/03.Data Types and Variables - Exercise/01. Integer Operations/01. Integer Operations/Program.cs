namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourtNum = int.Parse(Console.ReadLine());

           int first =  firstNum + secondNum;
            int second = first/ thirdNum;
            int third = second * fourtNum;
            Console.WriteLine(third);

        }
    }
}
