namespace _07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
     .Split()
     .Select(int.Parse)
     .ToList();

            string commands;
            int counter = 0;
            while ((commands = Console.ReadLine()) != "end")
            {
                string[] arguments = commands.Split();

                switch (arguments[0])
                {
                    case "Add":
                        int addNumber = int.Parse(arguments[1]);
                        numbers.Add(addNumber);
                        counter++;
                        break;
                    case "Remove":
                        int removeNumber = int.Parse(arguments[1]);
                        numbers.Remove(removeNumber);
                        counter++;
                        break;
                    case "RemoveAt":
                        int removeAtNumber = int.Parse(arguments[1]);
                        numbers.RemoveAt(removeAtNumber);
                        counter++;
                        break;
                    case "Insert":
                        int insertNumber = int.Parse(arguments[1]);
                        int index = int.Parse(arguments[2]);
                        numbers.Insert(index, insertNumber);
                        counter++;
                        break;
                    case "Contains":
                        int containsNumber = int.Parse(arguments[1]);
                        Console.WriteLine(numbers.Contains(containsNumber) ? "Yes" : "No such number");
                        break;
                    case "PrintEven":
                        List<int> evenNumbers = new List<int>(numbers.Where(x => x % 2 == 0));
                        Console.WriteLine(string.Join(" ", evenNumbers));
                        break;
                    case "PrintOdd":
                        List<int> oddNumbers = new List<int>(numbers.Where(x => x % 2 == 1));
                        Console.WriteLine(string.Join(" ", oddNumbers));
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":
                        string condition = arguments[1];
                        int conditionNumber = int.Parse(arguments[2]);

                        if (condition == "<")
                        {
                            List<int> result = new List<int>(numbers.Where(x => x < conditionNumber));
                            Console.WriteLine(string.Join(" ", result));
                        }
                        else if (condition == ">")
                        {
                            List<int> result = new List<int>(numbers.Where(x => x > conditionNumber));
                            Console.WriteLine(string.Join(" ", result));

                        }
                        else if (condition == ">=")
                        {
                            List<int> result = new List<int>(numbers.Where(x => x >= conditionNumber));
                            Console.WriteLine(string.Join(" ", result));
                        }
                        else if (condition == "<=")
                        {
                            List<int> result = new List<int>(numbers.Where(x => x <= conditionNumber));
                            Console.WriteLine(string.Join(" ", result));
                        }
                        break;
                }
            }

            Console.WriteLine(counter > 0 ? string.Join(" ", numbers) : null);




        }
    }
}
