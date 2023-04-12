using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Palindrome Chekcher");
        Console.WriteLine("Enter a word: ");
        string inputWord = Console.ReadLine();

        string[] words = inputWord.Split(' ');

        foreach (string word in words) 
        {
            string cleanWord = CleanWord(word);
            bool isPalindrome = IsPalindrome(cleanWord);
            Console.WriteLine(word + " " + (isPalindrome ? "Is Palindrome." : "Is not Palindrome."));
            Console.ReadKey();
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

    static bool IsPalindrome(string word)
    {
        int pointer1 = 0;
        int pointer2 = word.Length - 1;

        while (pointer1 < pointer2)
        {
            if (word[pointer1] != word[pointer2])
            {
                return false;
            }

            pointer1++;
            pointer2--;
        }
        
        return true;
    }
}
