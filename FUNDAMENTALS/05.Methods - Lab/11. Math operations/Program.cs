namespace _11._Math_operations
{
    internal class Program
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            string operatorr = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());

            double result = 0;
            switch (operatorr)
            {
                ///, *, + and -.
                case "/": result = firstNum / secondNum; break;
                case "*": result = firstNum * secondNum; break;
                case "+": result = firstNum + secondNum; break;
                case "-": result = firstNum - secondNum; break;
            }
            Console.WriteLine(result);
        }
    }
}
