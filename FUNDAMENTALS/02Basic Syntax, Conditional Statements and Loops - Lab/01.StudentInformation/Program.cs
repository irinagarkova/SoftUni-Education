string studentName = Console.ReadLine();
int ageStudent = int.Parse(Console.ReadLine());
double averageGrade = double.Parse(Console.ReadLine());

Console.WriteLine($"Name: {studentName}, Age: {ageStudent}, Grade: {averageGrade:f2}");