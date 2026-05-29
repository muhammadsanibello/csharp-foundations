// Example: Managing a list of students

List<Student> students = new List<Student>()
{
    new Student { Name = "Sani", Age = 20 },
    new Student { Name = "Usman", Age = 26}
};

students.Add(new Student { Name = "Gambo", Age = 35 });
students.RemoveAt(0); // Remove 'Sani'

foreach (Student student in students)
{
    Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
}

public class Student
{
    public string? Name { get; set; }
    public int Age { get; set; }
}