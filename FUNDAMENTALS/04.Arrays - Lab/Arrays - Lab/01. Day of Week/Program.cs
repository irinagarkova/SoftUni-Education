namespace _01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] days = {
            "Monday", // 0
            "Tuesday", //1 
            "Wednesday",//2
            "Thursday",//3
            "Friday",//4
            "Saturday",//5
            "Sunday"//6
            };
            int n = int.Parse(Console.ReadLine());

            if (n < 1 || n > 7)
            {
                Console.WriteLine("Invalid day!");
                return;
            }
            Console.WriteLine(days[n - 1]);

        }
    }
}
