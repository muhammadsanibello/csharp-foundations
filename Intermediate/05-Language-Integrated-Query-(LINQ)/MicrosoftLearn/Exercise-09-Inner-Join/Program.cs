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

// Single key join
var query = from department in departments
            join teacher in teachers on department.TeacherID equals teacher.ID
            select new
            {
                DepartmentName = department.Name,
                TeacherName = $"{teacher.First} {teacher.Last}",
            };

// Using Method syntax
var query1 = departments.Join(teachers,
    department => department.TeacherID, teacher => teacher.ID,
    (department, teacher) => new
    {
        DepartmentName = department.Name,
        TeacherName = $"{teacher.First} {teacher.Last}"
    });

foreach (var departmentAndTeacher in query1)
{
    Console.WriteLine($"{departmentAndTeacher.DepartmentName} is managed by {departmentAndTeacher.TeacherName}");
}

// Composite key join
// Join the too data sources based on a composite key consisting of first and last name,
// to determine which employees are also students
var query2 =
    from teacher in teachers
    join student in students on new
    {
        FirstName = teacher.First,
        LastName = teacher.Last
    } equals new
    {
        student.FirstName,
        student.LastName
    }
    select teacher.First + " " + teacher.Last;

// Using Method syntax
var query3 = teachers
    .Join(students,
    teacher => new { FirstName = teacher.First, LastName = teacher.Last },
    student => new { student.FirstName, student.LastName },
    (teacher, student) => $"{teacher.First} {teacher.Last}");

string result = "The following people are both teachers and students:\r\n";
foreach (var name in query3)
{
    result += $"{name}\r\n";
}
Console.WriteLine(result);

// Multiple join
// The first join matches Department.ID and Student.DepartmentID from the list of students
// and departments, based on a common ID. The second join matches teachers who lead departments
// with the students studying in that department.
var query4 =
    from student in students
    join department in departments on student.DepartmentID equals department.ID
    join teacher in teachers on department.TeacherID equals teacher.ID
    select new
    {
        StudentName = $"{student.FirstName} {student.LastName}",
        DepartmentName = department.Name,
        TeacherName = $"{teacher.First} {teacher.Last}"
    };

// Using Method syntax
var query5 = students
    .Join(departments,
    student => student.DepartmentID, department => department.ID,
    (student, department) => new
    {
        student,
        department
    })
    .Join(teachers,
    commonDepartment => commonDepartment.department.TeacherID, teacher => teacher.ID,
    (commonDepartment, teacher) => new
    {
        StudentName = $"{commonDepartment.student.FirstName} {commonDepartment.student.LastName}",
        DepartmentName = commonDepartment.department.Name,
        TeacherName = $"{teacher.First} {teacher.Last}"
    });
    

foreach (var obj in query5)
{
    Console.WriteLine($"""The student "{obj.StudentName}" studies in the department of "{obj.DepartmentName}" run by "{obj.TeacherName}".""");
}

// Inner join by using grouped join
var query6 =
    from department in departments
    join student in students on department.ID equals student.DepartmentID into gj
    from subStudent in gj
    select new
    {
        DepartmentName = department.Name,
        StudentName = $"{subStudent.FirstName} {subStudent.LastName}"
    };

// Using Method syntax
var query7 = departments.GroupJoin(students,
    department => department.ID, student => student.DepartmentID,
    (department, gj) => new { department, gj })
    .SelectMany(departmentAndStudent => departmentAndStudent.gj,
    (departmentAndStudent, subStudent) => new 
    {
        DepartmentName = departmentAndStudent.department.Name,
        StudentName = $"{subStudent.FirstName} {subStudent.LastName}"
    });

Console.WriteLine("Inner join using GroupJoin():");
foreach (var v in query7)
{
    Console.WriteLine($"{v.DepartmentName} - {v.StudentName}");
}