namespace _04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string type = Console.ReadLine();
            List<int> numbers = new List<int>();

            int start = range[0];
            int end = range[1];
            for (int i = start; i <= end; i++)
            {
                numbers.Add(i);
            }
            Predicate<int> isEven = x => x % 2 == 0; //четно 
            Predicate<int> isOdd = x => x % 2 != 0; // нечетно

            Console.WriteLine(string.Join(" ", numbers.FindAll(type == "even" ? isEven : isOdd)));
            //с тернарен оператор ? :

        }
    }
}
