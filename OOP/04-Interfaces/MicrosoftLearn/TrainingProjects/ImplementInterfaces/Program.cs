using ImplementInterfaces;

// Creating Student and Teacher objects
IPerson student = new Student { Name = "Sani Bello", Age = 20};

IPerson teacher = new Teacher { Name = "Usman Musa", Age = 26};

student.DisplayInfo();
teacher.DisplayInfo();