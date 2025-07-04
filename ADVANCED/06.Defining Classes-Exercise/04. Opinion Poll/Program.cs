namespace _04._Opinion_Poll
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
              
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                people.Add(new Person(name, age));
            }

            var filteredPeople = people.Where(p => p.Age > 30)
                                       .OrderBy(p => p.Name);

            foreach (var person in filteredPeople)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
