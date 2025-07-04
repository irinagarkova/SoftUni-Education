namespace _05._Courses
{
    internal class Program
    { 
    internal class Course
    {
        public Course(string name)
        {
            Name = name;
            StudentNames = new List<string>();
        }

        public string Name { get; set; }
        public List<string> StudentNames  { get; set; }

            public override string ToString()
            {
                string result = $"{Name}: {StudentNames.Count}\n";
                for (int i = 0; i < StudentNames.Count; i++)
                {
                    result += $"-- {StudentNames[i]}\n";
                }

                return result.Trim(); //маха всички празни символи 
            }
        }
        static void Main()
        {
            Dictionary<string, Course> coursesMap = new Dictionary<string, Course>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input.Split(" : ");

                string courseName = arguments[0];
                string studentsName = arguments[1];

                //има ли такъв клуч? ако го няма го добави
                if (!coursesMap.ContainsKey(courseName)) //проверяваме дали го НЯМА
                {
                    Course newCourse = new Course(courseName);
                    coursesMap.Add(courseName, newCourse);
                }
               // Course currCourse = coursesMap[courseName];
               // List<string> students = currCourse.StudentNames;
                //students.Add(studentsName);

                coursesMap[courseName].StudentNames.Add(studentsName); 
            }
            foreach (Course course in coursesMap.Values)
            {
                Console.WriteLine(course);
            }


        }
    }

}
