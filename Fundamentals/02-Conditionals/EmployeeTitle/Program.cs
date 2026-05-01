int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

// Using Switch statement
switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;

    case 300:
        title = "Manager";
        break;

    case 400:
        title = "Senior Manager";
        break;

    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");


/*// Using if, else-if, else statements
if (employeeLevel == 100)
    title = "Junior Associate";

else if (employeeLevel == 200)
    title = "Senior Associate";

else if (employeeLevel == 300)
    title = "Manager";

else if (employeeLevel == 400)
    title = "Senior Manager";

else
    title = "Associate";

Console.WriteLine($"{employeeName}, {title}");*/