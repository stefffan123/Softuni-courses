namespace EvenLines
{
    using System;
    using System.IO;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"D:\D\razni\KURS\C#\C# ADVANCED\10. Streams, Files and Directories - Exercises\Skeleton-Exercise\EvenLines\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder result = new StringBuilder();

            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                int lineNumber = 0;

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    if (lineNumber % 2 == 0)
                    {
                        line = line.Replace("-", "@").Replace(", ", "@").Replace(". ", "@").Replace("! ", "@").Replace("? ", "@");
                        string[] words = line.Split(' ');
                        Array.Reverse(words);
                        line = string.Join(' ', words);

                        result.AppendLine(line);
                    }

                    lineNumber++;
                }
            }        
            return result.ToString();

        }
    }
}
