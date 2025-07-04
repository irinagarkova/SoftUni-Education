namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //((daysInMonth * capsulesCount) * pricePerCapsule)
            int count = int.Parse(Console.ReadLine());
            double pricePerCoffe = 0;
            double totalPrice = 0;
            for (int i = 0; i < count; i++)
            {
               double pricePerCapsule = float.Parse(Console.ReadLine());
               int days = int.Parse(Console.ReadLine());
               int capsulesCount = int.Parse(Console.ReadLine());

                pricePerCoffe = (days * capsulesCount) * pricePerCapsule;
                totalPrice += pricePerCoffe;
                Console.WriteLine($"The price for the coffee is: ${pricePerCoffe:f2}");
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
