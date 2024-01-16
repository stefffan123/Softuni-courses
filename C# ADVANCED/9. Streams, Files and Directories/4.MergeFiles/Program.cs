using System.IO;
using System.Linq;

namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"E:\HDD D\KURS\C#\C# ADVANCED\9. Streams, Files and Directories\4.MergeFiles2\input1.txt";
            var secondInputFilePath = @"E:\HDD D\KURS\C#\C# ADVANCED\9. Streams, Files and Directories\4.MergeFiles2\input2.txt";
            var outputFilePath = @"E:\HDD D\KURS\C#\C# ADVANCED\9. Streams, Files and Directories\4.MergeFiles2\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string first, string second, string output)
        {
            string[] file1 = File.ReadAllLines(first);
            string[] file2 = File.ReadAllLines(second);

            using (var writer = new StreamWriter(output))
            {
                int lineNumber = 0;
                while (lineNumber < file1.Length || lineNumber < file2.Length)
                {
                    if (lineNumber < file1.Length)
                    {
                        writer.WriteLine(file1[lineNumber]);
                    }

                    if (lineNumber < file2.Length)
                    {
                        writer.WriteLine(file2[lineNumber]);
                    }

                    lineNumber++;
                }
            }
        }
    }
}
