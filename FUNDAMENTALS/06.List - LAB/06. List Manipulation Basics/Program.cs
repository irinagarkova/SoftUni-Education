namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = ReadListOfIntegers();
            string line = string.Empty;
            while ((line = Console.ReadLine()) != "end")
            {
                string[] tokens = line.Split();
                string command = tokens[0];
                if (command == "Add")
                {
                    numbers.Add(int.Parse(tokens[1]));
                }
                else if (command == "Remove")
                {
                    numbers.Remove(int.Parse(tokens[1]));
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(tokens[2]);
                    int number = int.Parse(tokens[1]);
                    numbers.Insert(index, number);
                }
                else
                {
                    int index = int.Parse(tokens[1]);  
                    numbers.RemoveAt(index);
                }

            }
                PrintResult(numbers);
        }
        static void PrintResult(List<int> numbers, string separator = " ")
        {
            Console.WriteLine(string.Join(separator, numbers));
        }
        static List<int> ReadListOfIntegers()
        {
            return Console.ReadLine().Split().Select(int.Parse).ToList();
        }
    }
}
