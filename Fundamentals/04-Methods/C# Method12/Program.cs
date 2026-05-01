string[] words = ["racecar", "talented", "deified", "tent", "tenet"];

Console.WriteLine("Is it a palindrome");

foreach (string word in words)
{
    Console.WriteLine($"{word} = {PalindromeWord(word)}");
}

bool PalindromeWord(string word)
{
    int start = 0;
    int end = word.Length - 1;
    for (int i = 0; i < word.Length; i++)
    {
        if (word[start] != word[end])
        {
            return false;
        }
        start++;
        end--;
    }

    return true;
}