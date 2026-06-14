using WalkthroughWritingLinqQueries;

// Create a data source by using a collection initializers
IEnumerable<Student> students =
[
    new Student(First: "Svetlana", Last: "Omelchenko", ID: 111, Scores: [97, 92, 81, 60]),
    new Student(First: "Claire", Last: "O'Donnell", ID: 112, Scores: [75, 84, 91, 39]),
    new Student(First: "Sven", Last: "Mortensen", ID: 113, Scores: [88, 94, 65, 91]),
    new Student(First: "Cesar", Last: "Garcia", ID: 114, Scores: [97, 89, 85, 82]),
    new Student(First: "Debra", Last: "Garcia", ID: 115, Scores: [35, 72, 91, 70]),
    new Student(First: "Fadi", Last: "Fakhouri", ID: 116, Scores: [99, 86, 90, 94]),
    new Student(First: "Hanying", Last: "Feng", ID: 117, Scores: [93, 92, 80, 87]),
    new Student(First: "Hugo", Last: "Garcia", ID: 118, Scores: [92, 90, 83, 78]),

    new Student("Lance", "Tucker",       119, [68, 79, 88, 92]),
    new Student("Terry", "Adams",        120, [99, 82, 81, 79]),
    new Student("Eugene", "Zabokritski", 121, [96, 85, 91, 60]),
    new Student("Michael", "Tucker",     122, [94, 92, 91, 91])
];

// Create the query.
// Using Query syntax
var studentQuery =
    from student in students
    where student.Scores[0] is > 90 && student.Scores[3] is < 80
    orderby student.Scores[0] descending
    select student;

// Using Method syntax
var studentQuery1 = students.Where(x => x.Scores[0] > 90 && x.Scores[3] < 80).OrderByDescending(x => x.Scores[0]);

// Execute the query
foreach (var student in studentQuery1)
{
    Console.WriteLine($"{student.Last}, {student.First} {student.Scores[0]}");
}

// Grouping the students by using the first letter of their family name as the key
//var groupsOfStudent1 = students.GroupBy(x => x.Last[0]).OrderBy(x => x.Key);
var groupsOfStudent =
    from student in students
    group student by student.Last[0] into studentGroup
    orderby studentGroup.Key
    select studentGroup;

foreach (var group in groupsOfStudent)
{
    Console.WriteLine(group.Key);
    foreach (var student in group)
    {
        Console.WriteLine($"    {student.Last}, {student.First}");
    }
}

// This query returns those students whose
// first test score was higher than their
// average score.
var studentQuery3 = students.Where(x => x.Scores.Average() < x.Scores[0]).Select(x => new {Last = x.Last, First = x.First});

var studentQuery2 =
    from student in students
    let totalScore = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
    where totalScore / 4 < student.Scores[0]
    select $"{student.Last}, {student.First}";

foreach (var student in studentQuery3)
{
    Console.WriteLine($"{student.Last}, {student.First}");
}

// Calculating the average of the class score
var studentQuery4 =
    from student in students
    let totalScore = student.Scores.Sum()
    select totalScore;

double averageScore = studentQuery4.Average();
Console.WriteLine($"Class average score = {averageScore}");

//This query returns the sequence of students whose total score is greater than the class average
var aboveAverageQuery =
    from student in students
    let x = student.Scores.Sum()
    where x > averageScore
    select new { id = student.ID, score = x };

foreach (var item in aboveAverageQuery)
{
    Console.WriteLine($"Student ID: {item.id}, Score: {item.score}");
}