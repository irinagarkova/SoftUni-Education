namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()); // POWER
            int M = int.Parse(Console.ReadLine()); // TARGETS
            int Y = int.Parse(Console.ReadLine());

            int count = 0;
            double percent = N * 0.5d;

            while (N >= M)
            {
                count++;
                N -= M;
                if (N == percent && Y != 0)
                {
                    N /= Y;
                }
            }
            Console.WriteLine(N);
            Console.WriteLine(count);
        }
    }
}
