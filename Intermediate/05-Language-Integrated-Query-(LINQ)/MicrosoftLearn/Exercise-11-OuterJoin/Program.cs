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

// Left outer join
var query =
    from student in students
    join department in departments on student.DepartmentID equals department.ID into gj
    from subgroup in gj.DefaultIfEmpty()
    select new
    {
        student.FirstName,
        student.LastName,
        Department = subgroup?.Name ?? string.Empty
    };

// Using Method syntax
var query1 = students.GroupJoin(departments,
    student => student.DepartmentID, department => department.ID,
    (student, departmentList) => new
    {
        student,
        subgroup = departmentList
    })
    .SelectMany(joinedSet => joinedSet.subgroup.DefaultIfEmpty(),
    (student, departments) => new
    {
        student.student.FirstName,
        student.student.LastName,
        Department = departments?.Name ?? string.Empty

    });

foreach (var v in query)
{
    Console.WriteLine($"{v.FirstName, -15} {v.LastName, -15}: {v.Department}");
}