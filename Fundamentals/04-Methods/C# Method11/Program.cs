// Reverse a String using method

string sentence = "there are snakes at the zoo";

Console.WriteLine(sentence);
Console.WriteLine(ReverseSentence(sentence));

string ReverseSentence(string sentence)
{
    string result = "";
    string[] words = sentence.Split(" ");

    foreach (string word in words)
    {
        result += ReverseWord(word) + " ";
    }

    return result.Trim();
}

string ReverseWord(string word)
{
    string result = "";

    for (int i = word.Length - 1; i >= 0; i--)
    {
        result += word[i];
    }

    return result;
}