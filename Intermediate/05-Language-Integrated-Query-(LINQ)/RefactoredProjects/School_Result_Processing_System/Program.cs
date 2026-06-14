using School_Result_Processing_System;
using System.Linq;
try
{
    // Student ID objects
    StudentID studentId1 = new StudentID("UG20235467");
    StudentID studentId2 = new StudentID("UG20235468");
    StudentID studentId3 = new StudentID("UG20235469");

    // Student objects
    Student student1 = new Student(studentId1, "Sani", "Bello", "CS", 100);
    Student student2 = new Student(studentId2, "Usman", "Musa", "CS", 200);
    Student student3 = new Student(studentId3, "Musa", "Alhassan", "CS", 300);

    // Course objects
    Course course1 = new Course("CSC301", "Data Structure", 3);
    Course course2 = new Course("CSC303", "Operating System", 3);
    Course course3 = new Course("CSC306", "Artificial Intelligence", 2);

    // Result objects
    Result result1 = new Result(course1, 70);
    Result result2 = new Result(course2, 50);
    Result result3 = new Result(course3, 40);

    School school = new School("Bauchi State University", "Gadau");

    school.AdmitStudent(student1);
    school.AdmitStudent(student2);
    school.AdmitStudent(student3);

    var student = school.FindStudent(studentId1);
    student.DisplayStudentInfo();

    school.AddCourse(course1);
    school.AddCourse(course2);
    school.AddCourse(course3);

    school.DisplayAllStudent();

    student1.RegisterCourse(course1);
    student1.RegisterCourse(course2);
    student1.RegisterCourse(course3);
    //student1.DropCourse(course3);

    student1.AddResult(result1);
    student1.AddResult(result2);
    student1.AddResult(result3);

    //student1.DropCourse(course3);

    student1.DisplayStudentInfo();
    student1.DisplayStudentResult();

    // Registered courses for student1
    var registeredCourses = student1.GetRegisteredCourses();

    Console.WriteLine("Student1 Registered Courses");

    if (registeredCourses is null || !registeredCourses.Any())
    {
        Console.WriteLine("No registered course available");
        return;
    }

    foreach (var registerdCourse in registeredCourses)
    {
        Console.WriteLine(registerdCourse);
    }
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}