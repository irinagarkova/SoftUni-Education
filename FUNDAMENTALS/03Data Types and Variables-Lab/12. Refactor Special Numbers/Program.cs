namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            int copyI = 0;

            bool isSpecialNum = false;

            for (int i = 1; i <= n; i++)
            {
                copyI = i;
                  while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);
                {
                    Console.WriteLine($"{copyI} -> {isSpecialNum}");
                }

                sum  = 0;
                i = copyI;

            }
        }
    }
}
