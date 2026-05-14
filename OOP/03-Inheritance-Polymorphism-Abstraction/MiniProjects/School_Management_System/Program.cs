using School_Management_System;

try
{

    // Creating Course objects
    var course1 = new Course("Data Structure", "CSC301", 3);
    var course2 = new Course("Artificial Intelligence", "CSC303", 2);
    var course3 = new Course("Operating System", "CSC306", 3);
    var course4 = new Course("Sampling Theory", "CSC308", 2);
    var course5 = new Course("Network Communication", "CSC310", 3);

    // Creating Student objects
    var student1 = new Student("Sani", "Bello", 20, "Computer Science", 4.56);
    var student2 = new Student("Usman", "Musa", 26, "Mathematics", 2.5);
    var student3 = new Student("Musa", "Alhassan", 23, "Statistics", 2.6);

    // Creating Teacher objects
    var teacher1 = new Teacher("Salisu", "Tata", 35, 150000);
    var teacher2 = new Teacher("Gambo", "Ibrahim", 45, 300000);

    // Creating Admin Staff object
    var admin1 = new AdminStaff("Idris", "Babayo", 45, "Exam Officer");

    // Creating School object
    var university = new School("Bayero University", 1000);

    // Demonstrating methods

    course1.DisplayCourseInfo();
    course2.DisplayCourseInfo();

    student1.DisplayInfo();
    student2.DisplayInfo();

    student1.RegisterCourse(course1);
    student1.RegisterCourse(course2);
    student1.UnRegisterCourse(course2);

    student1.DisplayRegisteredCourses();

    teacher1.DisplayInfo();

    teacher1.AssignCourse(course3);
    teacher1.AssignCourse(course3);
    teacher1.DisplayAssignedCourses();

    admin1.AssignDuty("Marking");
    admin1.DisplayInfo();

    university.AddPerson(student1);
    university.AddPerson(teacher1);
    university.AddPerson(admin1);

    // Test for duplicate add
    university.AddPerson(admin1);
    university.DisplayAllPeople();

    // Removing a person
    university.RemovePerson(student1);
    university.DisplayAllPeople();

    // Searching a person
    bool searchSuccess = university.SearchPerson(student1);

    if (searchSuccess)
    {
        Console.WriteLine("Found!");
    }
    else
    {
        Console.WriteLine("Not found");
    }
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}