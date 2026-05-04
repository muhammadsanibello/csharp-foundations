// Course Registration System

using CourseRegistrationSystem;

// Course objects
var course1 = new Course("Data Structure", "CSC301");
var course2 = new Course("Operating System", "CSC303");
var course3 = new Course("Artificial Intelligence", "CSC309");
var course4 = new Course("Peace Conflict Resolution", "GST301");
var course5 = new Course("Data Management", "DTS305");

// Student Objects
var student1 = new Student("Muhammad Sani Bello");
var student2 = new Student("Usman Musa Ibrahim");
var student3 = new Student("Musa Salihu Alhassan");
var student4 = new Student("Nafiu Muhammad Nasir");
var student5 = new Student("Muhammad Abdullahi");

student1.EnrollCourse(course1);
student1.EnrollCourse(course2);
student1.EnrollCourse(course3);
student1.EnrollCourse(course4);
student1.EnrollCourse(course5);
student1.DisplayCourses();

Console.WriteLine();

student2.EnrollCourse(course1);
student2.DisplayCourses();

Console.WriteLine();

student3.DisplayCourses();

Console.WriteLine();

student4.DisplayCourses();

Console.WriteLine();

student5.DisplayCourses();