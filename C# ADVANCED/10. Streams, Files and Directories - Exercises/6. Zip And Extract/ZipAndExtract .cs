namespace ZipAndExtract
{
    using System;
    using System.IO;
    using System.IO.Compression;

    public class ZipAndExtract
    {
        static void Main()
        {
            string inputFile = @"D:\D\razni\KURS\C#\C# ADVANCED\10. Streams, Files and Directories - Exercises\Skeleton-Exercise\ZipAndExtract\copyMe.png";
            string zipArchiveFile = @"D:\D\razni\KURS\C#\C# ADVANCED\10. Streams, Files and Directories - Exercises\Skeleton-Exercise\ZipAndExtract\archive.zip";
            string extractedFile = @"D:\D\razni\KURS\C#\C# ADVANCED\10. Streams, Files and Directories - Exercises\Skeleton-Exercise\ZipAndExtract\extracted.png";

            ZipFileToArchive(inputFile, zipArchiveFile);

            var fileNameOnly = Path.GetFileName(inputFile);
            ExtractFileFromArchive(zipArchiveFile, fileNameOnly, extractedFile);
        }

        public static void ZipFileToArchive(string inputFilePath, string zipArchiveFilePath)
        {
            // Create a new ZIP archive and add the input file to it
            using (FileStream zipToCreate = new FileStream(zipArchiveFilePath, FileMode.Create))
            {
                using (ZipArchive archive = new ZipArchive(zipToCreate, ZipArchiveMode.Create))
                {
                    // Add the file to the archive with its name only (no path)
                    archive.CreateEntryFromFile(inputFilePath, Path.GetFileName(inputFilePath));
                }
            }
        }

        public static void ExtractFileFromArchive(string zipArchiveFilePath, string fileName, string outputFilePath)
        {
            // Extract the specified file from the ZIP archive
            using (ZipArchive archive = ZipFile.OpenRead(zipArchiveFilePath))
            {
                // Find the entry with the specified file name
                ZipArchiveEntry entry = archive.GetEntry(fileName);

                // Extract the entry to the specified output file path
                entry.ExtractToFile(outputFilePath, true);
            }
        }
    }
}
