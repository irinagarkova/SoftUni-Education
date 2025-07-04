namespace _07._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleCatalog catalog = new VehicleCatalog();
            // ще получим line ще го сплитнем 
            //ако е трък адд ню трък if Truck --> catalog.Truck.Add(new Truck))
            // if car --> catalog.cars.add (new car())

        }
    }
    class Truck
    {
        public string Brand { get; set; }
        public int Model { get; set; }
        public int Weight { get; set; }
    }
    class Car
    {
        public string Brand { get; set; }
        public int Model { get; set; }
        public int HoursePower { get; set; }
    }
    class VehicleCatalog // ??
    {
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
    }

}
