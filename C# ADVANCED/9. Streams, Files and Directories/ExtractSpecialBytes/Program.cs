using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ExtractSpecialBytes
{
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"D:\D\razni\KURS\C#\C# ADVANCED\9. Streams, Files and Directories - Lab\ExtractSpecialBytes\example.png";
            string bytesFilePath = @"D:\D\razni\KURS\C#\C# ADVANCED\9. Streams, Files and Directories - Lab\ExtractSpecialBytes\bytes.txt";
            string outputPath = @"D:\D\razni\KURS\C#\C# ADVANCED\9. Streams, Files and Directories - Lab\ExtractSpecialBytes\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFile, string bytesFile, string output)
        {
            byte[] binaryData = File.ReadAllBytes(binaryFile);
            byte[] bytesToExtract = File.ReadAllLines(bytesFile).Select(byte.Parse).ToArray();

            using (var outputStream = new FileStream(output, FileMode.Create))
            {
                foreach (byte b in binaryData)
                {
                    if (bytesToExtract.Contains(b))
                    {
                        outputStream.WriteByte(b);
                    }
                }
            }
        }
    }
}
