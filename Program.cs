using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFilePath = "input.txt";
        string outputFilePath = "output.txt"; 

        try
        {
            string inputText = File.ReadAllText(inputFilePath);
            string[] words = inputText.Split(new char[] { ' ', '.', ',', '!', '?', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;

            File.WriteAllText(outputFilePath, $"Кількість слів у тексті: {wordCount}");
            Console.WriteLine("Кількість слів була записана у вихідний файл.");
        }
        catch (IOException e)
        {
            Console.WriteLine("Помилка читання/запису файлу: " + e.Message);
        }
    }
}
