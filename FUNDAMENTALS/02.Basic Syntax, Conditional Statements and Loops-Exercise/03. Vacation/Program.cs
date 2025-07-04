namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double price = 0;
            if (type == "Students")
            {
                switch (dayOfWeek)
                {
                    case "Friday": price = 8.45; break;
                    case "Saturday": price = 9.80; break;
                    case "Sunday": price = 10.46; break;
                }
            }
            else if (type == "Business")
            {
                switch (dayOfWeek)
                {
                    case "Friday": price = 10.90; break;
                    case "Saturday": price = 15.60; break;
                    case "Sunday": price = 16; break;
                }
            }
            else if (type == "Regular")
            {
                switch (dayOfWeek)
                {
                    case "Friday": price = 15; break;
                    case "Saturday": price = 20; break;
                    case "Sunday": price = 22.50; break;
                }
            }
            double totalPriceForPerson = countPeople * price;

            if (countPeople >= 30 && type == "Students")
            {
                double totalPriceForStudents = totalPriceForPerson * 0.85;
                Console.WriteLine($"Total price: {totalPriceForStudents:f2}");
            }
            else if (countPeople >= 100 && type == "Business")
            {
                countPeople -= 10;
                double totalPriceForBusiness = countPeople * totalPriceForPerson;
                Console.WriteLine($"Total price: {totalPriceForBusiness:f2}");
            }
            else if (countPeople >= 10 && countPeople <= 20 && type == "Regular")
            {
                double totalPriceForRegular = totalPriceForPerson * 0.95;
                Console.WriteLine($"Total price: {totalPriceForRegular:f2}");
            }
            else if (type == "Regular")
            {
                double totalPriceForRegularOver20 = countPeople * price;
                Console.WriteLine($"Total price: {totalPriceForRegularOver20:f2}");
            }
        }
    }
}
