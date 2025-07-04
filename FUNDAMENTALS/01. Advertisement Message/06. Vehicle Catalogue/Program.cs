namespace _06._Vehicle_Catalogue
{
    internal class Vehicle
    {
        public string Type { get; }
        public string Model { get; }
        public string Color { get; }
        public int HorsePower { get; }

        public Vehicle(string type, string model, string color, int horsePower)
        {
            switch (type)
            {
                case "car":
                    Type = "Car";

                    break;
                case "truck":
                    Type = "Truck";
                    break;
            }

            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
        public override string ToString()
        {
            return $"Type: {Type}\n" +
                   $"Model: {Model}\n" +
                   $"Color: {Color}\n" +
                   $"Horsepower: {HorsePower}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> catalogue = new List<Vehicle>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arg = input.Split();
                string type = arg[0];
                string model = arg[1];
                string color = arg[2];
                int hp = int.Parse(arg[3]);

                catalogue.Add(new Vehicle(type, model, color, hp));
            }

            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                string vehicleModel = input;
                Vehicle foundVehicle = catalogue.FirstOrDefault(v => v.Model == vehicleModel);

                if (foundVehicle != null)
                {
                    Console.WriteLine(foundVehicle);
                }
            }
            double averageHp = catalogue
                .Where(vehicle => vehicle.Type == "Car") //взима всички който са коли
                .Select(vehicle => vehicle.HorsePower)// взима само конете
                .DefaultIfEmpty()
                .Average(); //взимаме средните коне
            Console.WriteLine($"Cars have average horsepower of: {averageHp:F2}.");


            averageHp = catalogue
                .Where(vehicle => vehicle.Type == "Truck")
                .Select(vehicle => vehicle.HorsePower)
                .DefaultIfEmpty()
                .Average();
            Console.WriteLine($"Trucks have average horsepower of: {averageHp:F2}.");
        }

    }

}
