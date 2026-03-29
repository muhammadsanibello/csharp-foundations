// Using IndexOf() and Substring() helper methods;

using System.Runtime.CompilerServices;

string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

// Using IndexOf() and LastIndexOf() helper method;
Console.WriteLine("");
string message1 = "hello there!";

int first_h = message1.IndexOf("h");
int last_h = message1.LastIndexOf("h");

Console.WriteLine($"For the message: '{message1}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");

Console.WriteLine("");

string message2 = "(What if) I am (only interested) in the last (set of parentheses)?";

int openingPosition1 = message2.LastIndexOf('(');
openingPosition1 += 1;

int closingPosition1 = message2.LastIndexOf(')');
int length1 = closingPosition1 - openingPosition1;

Console.WriteLine(message2.Substring(openingPosition1, length1));

// Using while loop
Console.WriteLine("");

string message3 = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    int openingPosition2 = message3.IndexOf('(');
    if (openingPosition2 == -1)
    {
        break;
    }

    openingPosition2 += 1;

    int closingPosition2 = message3.IndexOf(')');
    int length2 = closingPosition2 - openingPosition2;

    Console.WriteLine(message3.Substring(openingPosition2, length2));

    message3 = message3.Substring(closingPosition2 + 1);
}

// Working with IndexOfAny() method
string message4 = "Hello, world!";
char[] charsToFind = { 'a', 'e', 'i' };

int index = message4.IndexOfAny(charsToFind);

Console.WriteLine($"Found '{message4[index]}' in '{message4}' at index: {index}.");

Console.WriteLine("");
string message5 = "Help (find) the (opening symbols)";
Console.WriteLine($"Searching THIS message: {message5}");
char[] openSymbols = { '[', '{', '(' };
int startPosition = 5;
int openingPosition3 = message5.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message5.Substring(openingPosition3)}");

openingPosition3 = message5.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}: {message5.Substring(openingPosition3)}");

// Using the Remove() and Replace() methods of string

string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);

Console.WriteLine("");

string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);