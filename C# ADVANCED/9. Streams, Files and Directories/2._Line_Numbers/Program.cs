namespace OddLines
{
    using System.IO;

    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"E:\HDD D\KURS\C#\C# ADVANCED\9. Streams, Files and Directories\OddLines\input.txt";
            string outputFilePath = @"E:\HDD D\KURS\C#\C# ADVANCED\9. Streams, Files and Directories\OddLines\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string a, string b)
        {
            using (var reader = new StreamReader(a))
            {
                using (var writer = new StreamWriter(b))
                {
                    var line = reader.ReadLine();
                    int counter = 0;

                    while (line != null)
                    {
                        if (counter % 2 != 0)
                        {
                            writer.WriteLine(line);
                        }
                        counter ++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
