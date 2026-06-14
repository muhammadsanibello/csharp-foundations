using StandardQueryOperators;

// Collections of Department objects
IEnumerable<Department> departments =
[
    new() { Name = "English",     ID = 1, TeacherID = 901 },
    new() { Name = "Mathematics", ID = 2, TeacherID = 965 },
    new() { Name = "Engineering", ID = 3, TeacherID = 932 },
    new() { Name = "Economics",   ID = 4, TeacherID = 945 },
    new() { Name = "Physics",     ID = 5, TeacherID = 987 },
    new() { Name = "Chemistry",   ID = 6, TeacherID = 901 }
];

// Collections of Students objects
IEnumerable<Student> students =
[
    new() { FirstName = "Svetlana", LastName = "Omelchenko", DepartmentID = 1,  Year = GradeLevel.FirstYear, ID = 111, Scores = [97, 90, 73, 54]},
    new() { FirstName = "Claire",   LastName = "O'Donnell",  DepartmentID = -1, Year = GradeLevel.FirstYear, ID = 112, Scores = [56, 78, 95, 95]},
    new() { FirstName = "Sven",     LastName = "Mortensen",  DepartmentID = 3,  Year = GradeLevel.SecondYear, ID = 113, Scores = [61, 52, 48, 72]},
    new() { FirstName = "Cesar",    LastName = "Garcia",     DepartmentID = 4,  Year = GradeLevel.SecondYear, ID = 114, Scores = [71, 86, 77, 97]},
    new() { FirstName = "Debra",    LastName = "Garcia",     DepartmentID = 5,  Year = GradeLevel.ThirdYear, ID = 115, Scores = [66, 96, 70, 69]},
    new() { FirstName = "Fadi",     LastName = "Fakhouri",   DepartmentID = 6,  Year = GradeLevel.ThirdYear, ID = 116, Scores = [93, 72, 62, 65]},
    new() { FirstName = "Hanying",  LastName = "Feng",       DepartmentID = 1,  Year = GradeLevel.FourthYear, ID = 117, Scores = [53, 81, 81, 50]},
    new() { FirstName = "Ann",     LastName = "Beebe",     DepartmentID = 2,  Year = GradeLevel.FourthYear, ID = 118, Scores = [68, 91, 60, 51]},
    new() { FirstName = "Lance",    LastName = "Turker",     DepartmentID = -1, Year = GradeLevel.FirstYear, ID = 119, Scores = [83, 42, 68, 63]},
    new() { FirstName = "Alex",    LastName = "Robinson",      DepartmentID = 4,  Year = GradeLevel.SecondYear, ID = 120, Scores = [63, 91, 71, 51]}
];

// Collections of Teacher objects
IEnumerable<Teacher> teachers =
[
    new() { First = "Ann", Last = "Beebe", ID = 901, City = "Seatle"},
    new() { First = "Alex", Last = "Robinson", ID = 910, City = "Redmond"},
    new() { First = "Michiyo", Last = "Sato", ID = 921, City = "Tacoma"},
    new() { First = "Aylin", Last = "Lundgren", ID = 932, City = "Seatle"},
    new() { First = "Gleb", Last = "Seleznyov", ID = 943, City = "Redmond"},
    new() { First = "Alexandra", Last = "Voronova", ID = 954, City = "Tacoma"},
    new() { First = "Kevin", Last = "McDowell", ID = 965, City = "Redmond"},
    new() { First = "Selma", Last = "Myberg", ID = 976, City = "Seatle"},
    new() { First = "Selma", Last = "Astrom", ID = 987, City = "Redmond"},
    new() { First = "Hillevi", Last = "Bengtsson", ID = 998, City = "Tacoma"}
];

// Perform Group join
var query =
    from department in departments
    join student in students on department.ID equals student.DepartmentID into Students
    select new
    {
        DepartmentName = department.Name,
        Students
    };

// Using method syntax
var query1 = departments.GroupJoin(students,
    department => department.ID, student => student.DepartmentID,
    (department, Students) => new
    {
        DepartmentName = department.Name,
        Students
    });

foreach (var v in query1)
{
    // Output the department name
    Console.WriteLine($"{v.DepartmentName}");

    // Output each of the students in that department
    foreach (var student in v.Students)
    {
        Console.WriteLine($"    {student.FirstName} {student.LastName}");
    }
}