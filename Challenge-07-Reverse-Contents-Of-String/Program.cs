// Challenge of reversing words in a sentence

using System.Runtime.CompilerServices;

string pangram = "The quick brown fox jumps over the lazy dog";
string[] sentence = pangram.Split(' ');

string[] newSentence = new string[sentence.Length];

for (int i = 0; i < sentence.Length; i++)
{
    char[] letters = sentence[i].ToCharArray();
    Array.Reverse(letters);
    newSentence[i] = new string(letters);
}

string result = String.Join(" ", newSentence);
Console.WriteLine(result);
