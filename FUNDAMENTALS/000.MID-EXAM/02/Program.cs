namespace _02_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] vehicles = input.Split(">>");
            double totalTaxs = 0;

            foreach (string vehicle in vehicles)
            {
                string[] vehicleDetails = vehicle.Split(" ");
                string carType = vehicleDetails[0];
                int years = int.Parse(vehicleDetails[1]);
                int kilometers = int.Parse(vehicleDetails[2]);

                double taxs =0;

                if (carType == "family")
                {
                    //такса 50 евро
                    taxs = 50 - 5 * years;
                    taxs = taxs + 12 * (kilometers / 3000);

                }
                else if (carType == "heavyDuty")
                {
                    //такса 80 евро
                    taxs = 80 - 8 * years;
                    taxs = taxs + 14 * (kilometers / 9000);
                }
                else if (carType == "sports")
                {
                    //такса 100 евро
                    taxs = 100 - 9 * years;
                    taxs = taxs + 18 * (kilometers / 2000);
                }
                else
                {
                    Console.WriteLine("Invalid car type.");
                    continue;
                }
              
                totalTaxs += taxs;
                Console.WriteLine($"A {carType} car will pay {taxs:F2} euros in taxes.");

            }
            Console.WriteLine($"The National Revenue Agency will collect {totalTaxs:f2} euros in taxes.");

        }
    }
}
