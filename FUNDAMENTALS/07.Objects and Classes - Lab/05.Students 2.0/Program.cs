
namespace _05.Students_2._0
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
                string firstName = studentTokens[0];
                string lastName = studentTokens[1];
                int age =int.Parse(studentTokens[2]);
                string homeTown = studentTokens[3];

                Student student = IsStudentExisting(students, firstName, lastName);
              
                if (student == null)
                {
                    students.Add(new Student
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = homeTown
                    });

                }
                else
                {
                    student.Age = age;
                    student.HomeTown = homeTown;
                }
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

        private static Student IsStudentExisting(List<Student> students, string firstName, string lastName)
        {
            Student result = null;
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    result = student;
                }
            }
            return result;
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
