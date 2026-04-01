using System.Runtime.CompilerServices;

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = input.IndexOf(openSpan);
int closingPosition = input.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;

quantity = "Quantity: " + input.Substring(openingPosition, length);

const string openDiv = "<div>";
int divIndex1 = input.IndexOf(openDiv);

output = input.Remove(divIndex1, openDiv.Length);

const string closeDiv = "</div>";
int divIndex2 = output.IndexOf(closeDiv);

output = output.Remove(divIndex2, closeDiv.Length);

const string replace = "&trade";
const string insert = "&reg";

output = "Output: " + output.Replace(replace, insert);

Console.WriteLine(quantity);
Console.WriteLine(output);