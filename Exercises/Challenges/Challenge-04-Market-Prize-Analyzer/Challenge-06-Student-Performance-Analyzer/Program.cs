// A Student Performance Analyzer Program

string? readResult;
string noOfStudents = "";
int numberOfStudents;

Console.WriteLine("How many students are in the class?");
readResult = Console.ReadLine();

if (readResult == "0")
{
    Console.WriteLine("\nNo students to analyze.");
    return;
}

if (readResult != null)
{
    noOfStudents = readResult.Trim();
}

bool number = int.TryParse(noOfStudents, out numberOfStudents);

if (numberOfStudents <= 0)
{
    Console.WriteLine("Invalid Number of Student");
    return;
}

string[] studentNames = new string[numberOfStudents];
int[] studentScores = new int[numberOfStudents];

for (int i = 0; i < numberOfStudents; i++)
{
    Console.WriteLine("\nEnter student`s name:");
    readResult = Console.ReadLine();

    if ((!string.IsNullOrEmpty(readResult)) && (readResult.All(char.IsLetter)))
    {
        studentNames[i] = readResult;
    }

    else
    {
        Console.WriteLine("Name cannot be empty or contain number");
        break;
    }

    Console.WriteLine("\nEnter exam score (0-100):");
    readResult = Console.ReadLine();

    if ((!string.IsNullOrEmpty(readResult)) && (readResult.All(char.IsDigit)))
    {
        int score = int.Parse(readResult);

        if ((score >= 0) && (score <= 100))
        {
            studentScores[i] = score;
        }
        else
        {
            Console.WriteLine("Score must be between 0-100");
            break;
        }
    }

    else
    {
        Console.WriteLine("Score cannot be empty or contains letter.");
        break;
    }
}

int totalScore = 0;
decimal averageScore = 0;
int highestScore = studentScores[0];
int lowestScore = studentScores[0];
int excellent = 0;
int pass = 0;
int fail = 0;

foreach (var score in studentScores)
{
    totalScore += score;
      
    if (score > highestScore)  // Finding maximum score
    {
        highestScore = score;
    }

    if (score < lowestScore)  // Finding minimum score
    {
        lowestScore = score;
    }

    if (score >= 70)
    {
        excellent++;
    }

    else if (score >= 50)
    {
        pass++;
    }

    else
    {
        fail++;
    }
}

averageScore = (decimal)totalScore / numberOfStudents;

// Summary
Console.WriteLine("");
Console.WriteLine($"Class Average: {averageScore:N}");
Console.WriteLine($"Highest Score: {highestScore}");
Console.WriteLine($"Lowest Score: {lowestScore}");
Console.WriteLine($"Excellent (70+): {excellent}");
Console.WriteLine($"Pass (50-69): {pass}");
Console.WriteLine($"Fail (<50): {fail}");
Console.WriteLine("\nPress Enter key to continue");
readResult = Console.ReadLine();