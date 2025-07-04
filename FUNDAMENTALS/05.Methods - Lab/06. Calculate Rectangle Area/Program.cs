namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = CalculateArea(width, height);
            Console.WriteLine(area);

        }
        static double CalculateArea(double width, double height)
        {
            return width * height;
        }
    }
}
