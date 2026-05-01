// Pallets identifier
string value = "abc123";
// Converting string to char array
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
//string result = new string(valueArray);
string result = String.Join("-", valueArray);
Console.WriteLine(result);

// Converting string to string array
string[] items = result.Split('-');
foreach (string item in items)
{
    Console.WriteLine(item);
}