namespace FolderSize
{
    public class FolderSize
    {
        static void Main()
        {
            string folderPath = @"D:\D\razni\KURS\C#\C# ADVANCED\9. Streams, Files and Directories - Lab\7FolderSize\TestFolder";
            string outputPath = @"D:\D\razni\KURS\C#\C# ADVANCED\9. Streams, Files and Directories - Lab\7FolderSize\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            long totalSize = 0;

            // Get all files in the folder and its subfolders
            string[] files = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories);

            // Calculate the total size of all files
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                totalSize += fileInfo.Length;
            }

            // Convert bytes to kilobytes
            double totalSizeKB = totalSize / 1024.0;

            // Write the result to the output file
            File.WriteAllText(outputFilePath, $"{totalSizeKB} KB");
        }
    }
}
