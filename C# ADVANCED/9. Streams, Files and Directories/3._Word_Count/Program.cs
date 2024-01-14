using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

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
            using (var reader = new StreamReader(words_A))
            {
                var wordsCount = new Dictionary<string, int>();
                string[] words = reader.ReadToEnd().Split();
                
                foreach (string word in words)
                {
                    if (!wordsCount.ContainsKey(word))
                    {
                        wordsCount[word] = 0;
                    }
                }

                using (var reader2 = new StreamReader(text_B))
                {
                    string[] textWords = reader2.ReadToEnd()
                                                .Split(new string[] { " ", "\t", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                                                .Select(word => Regex.Match(word, @"[A-Za-z']*[A-Za-z]{1}").Value.ToLower())
                                                .ToArray();

                    foreach (string word in textWords)
                    {
                        if (wordsCount.ContainsKey(word))
                        {
                            wordsCount[word]++;
                        }
                    }
                }

                using (var writer = new StreamWriter(output_C))
                {
                    foreach (var word in wordsCount.OrderByDescending(w => w.Value))
                    {
                        writer.WriteLine($"{word.Key} - {word.Value}");
                    }
                }
            }
        }
    }
}
