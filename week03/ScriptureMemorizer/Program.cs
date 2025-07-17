// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        
//     }
// }

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = LoadScriptures("scriptures.txt");
        Scripture scripture = scriptures[new Random().Next(scriptures.Count)];

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
                break;

            scripture.HideRandomWords(3); // Hide 3 words per round
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words hidden. Great job!");

        /*
         * Enhancements beyond core requirements:
         * - Loads scriptures from a file ("scriptures.txt")
         * - Randomly selects a scripture from the library
         * - Only hides words that are not already hidden
         * - Displays progress percentage of hidden words
         */
    }

    static List<Scripture> LoadScriptures(string filePath)
    {
        var scriptures = new List<Scripture>();
        if (!File.Exists(filePath))
        {
            // Fallback scripture if file is missing
            scriptures.Add(new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."));
            return scriptures;
        }

        foreach (var line in File.ReadAllLines(filePath))
        {
            var parts = line.Split('|');
            if (parts.Length == 2)
                scriptures.Add(new Scripture(new Reference(parts[0]), parts[1]));
        }

        return scriptures;
    }
}