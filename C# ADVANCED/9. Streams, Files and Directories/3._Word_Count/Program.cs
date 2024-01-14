using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"E:\HDD D\KURS\C#\C# ADVANCED\9. Streams, Files and Directories\3._Word_Count\words.txt";
            string textPath = @"E:\HDD D\KURS\C#\C# ADVANCED\9. Streams, Files and Directories\3._Word_Count\text.txt";
            string outputPath = @"E:\HDD D\KURS\C#\C# ADVANCED\9. Streams, Files and Directories\3._Word_Count\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string words_A, string text_B, string output_C)
        {
            var dictionary = new SortedDictionary<string, int>();
            string inputWords = File.ReadAllText(words_A);
            string[] words = inputWords.Split();
            using var writer = new StreamWriter(output_C);

            using (var reader = new StreamReader(text_B))
            {
                string currentSentence = reader.ReadLine();

                while (currentSentence != null)
                {
                    foreach (var word in words)
                    {
                        if (currentSentence.ToLower().Contains(word))
                        {

                            if (!dictionary.ContainsKey(word))
                            {
                                dictionary.Add(word, 0);
                                dictionary[word]++;
                            }
                            else
                            {
                                dictionary[word]++;
                            }
                        }
                    }

                    currentSentence = reader.ReadLine();
                }

                foreach (var word in dictionary.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}

