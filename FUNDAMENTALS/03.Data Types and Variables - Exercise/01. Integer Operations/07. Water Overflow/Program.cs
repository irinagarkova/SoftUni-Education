namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int totalCapacity = 0;

            for (int i = 0; i < lines; i++)
            {
              int nLittersWater = int.Parse(Console.ReadLine());
                if (totalCapacity + nLittersWater > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    totalCapacity += nLittersWater;
                
                }
            } 
            Console.WriteLine(totalCapacity);

        }
    }
}
