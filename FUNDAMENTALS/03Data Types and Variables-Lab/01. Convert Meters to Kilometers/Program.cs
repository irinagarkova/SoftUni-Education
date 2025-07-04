namespace _01._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kilometers = int.Parse(Console.ReadLine());
            double kilometersToMeters = kilometers / 1000.0;
            Console.WriteLine($"{kilometersToMeters:f2}");
        }
    }
}
