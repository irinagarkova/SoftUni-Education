namespace _11._Refactor_Volume_of_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lenght = 0;
            double width = 0;
            double height = 0;

            Console.Write("Length: ");

            lenght = double.Parse(Console.ReadLine());

            Console.Write("Width: ");

            width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");

            height = double.Parse(Console.ReadLine());

            double volume = (lenght * width * height) / 3;

            Console.WriteLine($"Pyramid Volume: {volume:f2}");
        }
    }
}
