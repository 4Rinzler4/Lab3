using System;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть текст: ");
        string inputText = Console.ReadLine();

        string[] words = inputText.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        int countEqualVowelsConsonants = CountWordsWithEqualVowelsConsonants(words);

        Console.WriteLine($"Кількість слів які містять однакову кількість голосних і приголосних літер: {countEqualVowelsConsonants}");

        string longestWord = FindLongestWord(words);
        Console.WriteLine($"Найдовше слово: {longestWord}");
    }
    static int CountWordsWithEqualVowelsConsonants(string[] words)
    {
        int count = 0;
        foreach (string word in words)
        {
            if (HasEqualVowelsConsonants(word))
            {
                count++;
            }
        }
        return count;
    }

    static bool HasEqualVowelsConsonants(string word)
    {
        int vowels = 0;
        int consonants = 0;

        foreach (char c in word.ToLower())
        {
            if (char.IsLetter(c))
            {
                if ("aeiouаеиоуі".Contains(c))
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }
            }
        }

        return vowels == consonants;
    }

    static string FindLongestWord(string[] words)
    {
        string longestWord = "";
        foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }
        return longestWord;
    }
}