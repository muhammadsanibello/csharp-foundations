using SchoolRegistrationSystem;

// Student objects
var student1 = new Student("Muhammad Sani Bello");
var student2 = new Student("Usman Musa Ibrahim");

// Course objects
var course1 = new Course("Introduction to Cybersecurity", "CYB301");
var course2 = new Course("Communication Network", "ICT305");
var course3 = new Course("Data Management", "DTS305");

student1.EnrollCourse(course1);
student1.EnrollCourse(course2);
student1.EnrollCourse(course2);
student1.EnrollCourse(course3);
student1.EnrollCourse(course3);
student1.DisplayCourses();

Console.WriteLine();
student2.EnrollCourse(course1);
student2.DisplayCourses();


