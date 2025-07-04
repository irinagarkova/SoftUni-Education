namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] studentTokens = input.Split();
                Student student = new Student()
                {
                    FirstName = studentTokens[0],
                    LastName = studentTokens[1],
                    Age = int.Parse(studentTokens[2]),
                    HomeTown = studentTokens[3]
                };
                students.Add(student);
            }
            string filter = Console.ReadLine();
            foreach (var student in students)
            {
                if (student.HomeTown == filter)
                {
                    Console.WriteLine(student.GetStudentInformation);
                }
            }

        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }

        public string GetStudentInformation
        {
            get
            {
                return $"{FirstName} {LastName} is {Age} years old.";
            }
        }

    }
}
