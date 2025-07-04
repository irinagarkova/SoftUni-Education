namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> listOfPersons = new List<Person>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arg = input.Split();
                Person newPerson = new Person(arg[0], arg[1], int.Parse(arg[2]));

                Person foundPerson = listOfPersons.FirstOrDefault(person => person.Id == newPerson.Id);

                if (foundPerson != null)
                {
                    foundPerson.Age = newPerson.Age;
                    foundPerson.Name = newPerson.Name;
                }
                else
                {
                    listOfPersons.Add(newPerson);
                
                }  
            }
            List<Person> orderedPeople = listOfPersons
                .OrderBy(person => person.Age)
                .ToList();

            foreach (Person person in orderedPeople)
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }

        }
        class Person 
        {
             public string Name { get; set; }
             public string Id { get; set; } 
             public int Age { get; set; }

            public Person(string name, string id, int age)
            {
                Name = name;
                Id = id;
                Age = age;
            }
        }
    }
}
