/*int[,] numbers = { {1, 4, 2}, {3, 6, 8}, {2, 4, 5} };
Console.WriteLine(numbers[1, 1]);
numbers[1, 1] = 5;
Console.WriteLine(numbers[1, 1]);
Console.WriteLine();

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        Console.WriteLine(numbers[i, j]);
    }
}*/

using System.Reflection.Metadata;

string[,] array1 = new string[,]
{
    {"cat", "dog"},
    {"bird", "fish"}
};

Console.WriteLine(array1[0, 0]);
Console.WriteLine(array1[1, 1]);

int[] one = new int[2];
one[0] = 1;
one[1] = 2;

int[,] two = new int[2, 2];
two[0, 0] = 0;
two[0, 1] = 1;
two[1, 0] = 2;
two[1, 1] = 3;