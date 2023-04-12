using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a word: ");
        string inputWord = Console.ReadLine();

        string[] words = inputWord.Split(' ');

        foreach (string word in words) 
        {
          string cleanWord = CleanWord(word);
            Console.WriteLine(cleanWord);
        }
    }

    static string CleanWord(string word)
    {
        string cleanWord = "";

        foreach (char c in word)
        {
            if (Char.IsLetter(c))
            {
                cleanWord += Char.ToLower(c);
            }
        }

        return cleanWord;
    }
}
