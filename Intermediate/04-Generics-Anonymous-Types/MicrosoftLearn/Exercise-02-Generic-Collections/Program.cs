// Using a generic list
List<int> numbers = new List<int>();
numbers.Add(1); ;
numbers.Add(2);
numbers.Add(3); ;

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

// Using generic method
T GetFirstItem<T>(List<T> items)
{
    return items[0];
}

List<string> names = new List<string> { "Hannah", "Mario" };
string firstName = GetFirstItem(names);
Console.WriteLine(firstName);