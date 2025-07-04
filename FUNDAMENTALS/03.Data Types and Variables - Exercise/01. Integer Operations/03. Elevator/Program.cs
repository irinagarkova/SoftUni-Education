namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nPersons = int.Parse(Console.ReadLine());
            int capacityOfPeson = int.Parse(Console.ReadLine());
            int courses = 0;

            courses = nPersons / capacityOfPeson;
            if (nPersons > capacityOfPeson)
            {
                courses = nPersons % capacityOfPeson;
            }
                courses = (int)Math.Ceiling((double) nPersons / capacityOfPeson);
              
            Console.WriteLine(courses);
        }
    }
}
