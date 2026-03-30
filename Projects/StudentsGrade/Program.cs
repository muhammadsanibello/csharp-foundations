// Students Scores
int[] saniScores = { 7, 7, 8, 10, 45 };
int[] musaScores = { 5, 7, 6, 8, 35 };
int[] nafiuScores = { 4, 7, 5, 10, 30 };
int[] usmanScores = { 3, 7, 5, 10, 30 };

// Students Names
string[] studentNames = { "Sani", "Musa", "Nafiu", "Usman" };

int[] studentScores = new int[10];

string letterGrade = "";

Console.WriteLine("Student\t\tScore\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sani")
        studentScores = saniScores;

    else if (currentStudent == "Musa")
        studentScores = musaScores;

    else if (currentStudent == "Nafiu")
        studentScores = nafiuScores;

    else if (currentStudent == "Usman")
        studentScores = usmanScores;

    int totalStudentScores = 0;

    foreach (int score in studentScores)
    {
        totalStudentScores += score;
    }

    if (totalStudentScores >= 70)
        letterGrade = "A";

    else if (totalStudentScores >= 60)
        letterGrade = "B";

    else if (totalStudentScores >= 50)
        letterGrade = "C";

    else if (totalStudentScores >= 45)
        letterGrade = "D";

    else if (totalStudentScores >= 40)
        letterGrade = "E";
    else
        letterGrade = "F";

    Console.WriteLine($"{currentStudent}\t\t{totalStudentScores}\t{letterGrade}\n");
}

Console.WriteLine("Press Enter key to Exit.");
Console.ReadLine();