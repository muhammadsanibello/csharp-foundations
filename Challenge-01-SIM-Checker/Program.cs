// A Student Performance Analyzer Program

string? readResult;
string noOfStudents = "";
int numberOfStudents;

Console.WriteLine("How many students are in the class?")
readResult = Console.ReadLine();

if (readResult != null)
{
    noOfStudents = readResult.Trim();
}

bool number = int.TryParse(noOfStudents, out numberOfStudents);

if (numberOfStudents == 0)
{
    Console.WriteLine("\nNo students to analyze.");
    return;
}

string[] studentNames = new string[numberOfStudents];
int[] studentScores = new int[numberOfStudents];

for (int i = 0; i < numberOfStudents; i++)
{
    Console.WriteLine("\nEnter student`s name:");
    readResult = Console.ReadLine();

    if ((!string.IsNullOrEmpty(readResult)) && (readResult.All))
        studentNames[i] += readResult;

    Console.WriteLine("\nEnter exam score (0-100):");
    readResult = Console.ReadLine();
    studentScores[i] += int.Parse(readResult);
}