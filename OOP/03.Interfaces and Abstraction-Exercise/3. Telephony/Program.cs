namespace _3._Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] websites = Console.ReadLine().Split();

            SmartPhone smartPhone = new SmartPhone();
            StationaryPhone stationaryPhone = new StationaryPhone();

            foreach (string phoneNumber in phoneNumbers)
            {
                if (phoneNumber.Any(s => !char.IsDigit(s))) Console.WriteLine("Invalid number!");
                else if (phoneNumber.Length == 10) Console.WriteLine(smartPhone.Call(phoneNumber));
                else if (phoneNumber.Length == 7) Console.WriteLine(stationaryPhone.Call(phoneNumber));
            }
            foreach (string website in websites)
            {
                if (website.Any(s => char.IsDigit(s))) Console.WriteLine("Invalid URL!");
                else Console.WriteLine(smartPhone.Browse(website)) ;
            }
        }
    }
}
