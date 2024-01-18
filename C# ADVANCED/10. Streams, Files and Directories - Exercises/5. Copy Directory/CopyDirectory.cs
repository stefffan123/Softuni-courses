namespace CopyDirectory
{
    using System;
    using System.IO;

    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath = @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            // Check if the output directory exists, and delete it if it does
            if (Directory.Exists(outputPath))
            {
                Directory.Delete(outputPath, true);
            }

            // Create the output directory
            Directory.CreateDirectory(outputPath);




            // Get all files in the input directory
            string[] files = Directory.GetFiles(inputPath);

            foreach (string item in files)
            {
                // Construct the destination path for each file
                string destFile = Path.Combine(outputPath, Path.GetFileName(item));

                // Copy the file to the destination
                File.Copy(item, destFile);
            }
        }
    }
}
