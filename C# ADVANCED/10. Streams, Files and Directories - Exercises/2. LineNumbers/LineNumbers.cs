namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"D:\D\razni\KURS\C#\C# ADVANCED\10. Streams, Files and Directories - Exercises\Skeleton-Exercise\LineNumbers\text.txt";
            string outputFilePath = @"D:\D\razni\KURS\C#\C# ADVANCED\10. Streams, Files and Directories - Exercises\Skeleton-Exercise\LineNumbers\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] lines = File.ReadAllLines(inputFilePath);
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    string lineWithNumber = $"Line {i + 1}: {lines[i]}";
                    int letterCount = Regex.Matches(lines[i], @"[a-zA-Z]").Count;
                    int punctuationCount = Regex.Matches(lines[i], @"[^\w\s]").Count;
                    writer.WriteLine($"{lineWithNumber} ({letterCount}) ({punctuationCount})");
                }
            }
        }
    }
}
