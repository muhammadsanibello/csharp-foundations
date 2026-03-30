bool flag = true;
int value = 0;

if (flag)
{
    Console.WriteLine($"Inside the code block: {value}");
}
value = 10;
Console.WriteLine($"Outside the code block: {value}");

// Code sample 1
/*bool flag1 = true;
int value1;

if (flag1)
{
    value1 = 10;
    Console.WriteLine($"Inside the code block: {value1}");
}

Console.WriteLine($"Outside the code block: {value1}");  // The error will coccur because the variable "value1" is not assigned 
*/

//Code sample 2
int value2;

if (true)
{
    value2 = 10;
    Console.WriteLine($"Inside the code block 2: {value2}");
}
value2 = 20;
Console.WriteLine($"Outside the code block 2: {value2}");

bool flag2 = true;
if (flag2)
    Console.WriteLine(flag2);

string name = "Steve";

if (name == "bob")
    Console.WriteLine("Found bob");
else if (name == "Steve")
    Console.WriteLine("Found steve");
else
    Console.WriteLine("Found Chuck");