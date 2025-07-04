namespace _01._Car
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "Audi";
            car.Model = "A5";
            car.Year = 2010;
            car.FuelQuantity = 20;
            Console.WriteLine($"Make: {car.Make}");
            Console.WriteLine($"Model: {car.Model}");
            Console.WriteLine($"Year: {car.Year}");
            Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
        }
    }
}
