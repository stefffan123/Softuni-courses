namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();   // input dir for travers
            string reportFileName = @"D:\Users\stefan\Desktop\final.txt"; // output path and file

            string reportContent = TraverseDirectory(path); // 1st Method
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);    // 2nd Method
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            Dictionary<string, List<FileInfo>> fileGroups = new Dictionary<string, List<FileInfo>>();
            DirectoryInfo directory = new DirectoryInfo(inputFolderPath);

            foreach (FileInfo file in directory.GetFiles())
            {
                string extension = file.Extension;

                if (!fileGroups.ContainsKey(extension))
                {
                    fileGroups[extension] = new List<FileInfo>();
                }

                fileGroups[extension].Add(file);
            }

            StringBuilder reportBuilder = new StringBuilder();

            foreach (var group in fileGroups.OrderByDescending(g => g.Value.Count)
                                             .ThenBy(g => g.Key))
            {
                reportBuilder.AppendLine(group.Key);

                foreach (var file in group.Value.OrderBy(f => f.Length))
                {
                    reportBuilder.AppendLine($"--{file.Name} - {file.Length / 1024.0:F3}kb");
                }
            }

            return reportBuilder.ToString();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string reportFilePath = Path.Combine(desktopPath, reportFileName);
            File.WriteAllText(reportFilePath, textContent);
        }
    }
}
