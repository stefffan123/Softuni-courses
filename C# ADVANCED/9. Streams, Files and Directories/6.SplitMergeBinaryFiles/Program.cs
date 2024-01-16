using System.IO;
using System;

namespace SplitMergeBinaryFile
{
    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"D:\D\razni\KURS\C#\C# ADVANCED\9. Streams, Files and Directories - Lab\proba\example.png";
            string joinedFilePath = @"D:\D\razni\KURS\C#\C# ADVANCED\9. Streams, Files and Directories - Lab\proba\example-joined.png";
            string partOnePath = @"D:\D\razni\KURS\C#\C# ADVANCED\9. Streams, Files and Directories - Lab\proba\part-1.bin";
            string partTwoPath = @"D:\D\razni\KURS\C#\C# ADVANCED\9. Streams, Files and Directories - Lab\proba\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            {
                long totalBytes = sourceStream.Length;
                int partSize = (int)Math.Ceiling((double)totalBytes / 2);

                using (FileStream partOneStream = new FileStream(partOneFilePath, FileMode.Create, FileAccess.Write))
                {
                    while (partOneStream.Length < partSize)
                    {
                        int byteRead = sourceStream.ReadByte();
                        if (byteRead == -1)
                            break;

                        partOneStream.WriteByte((byte)byteRead);
                    }
                }

                using (FileStream partTwoStream = new FileStream(partTwoFilePath, FileMode.Create, FileAccess.Write))
                {
                    int byteRead = 0;
                    while ((byteRead = sourceStream.ReadByte()) != -1)
                    {
                        partTwoStream.WriteByte((byte)byteRead);
                    }
                }
            }
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            using (FileStream joinedStream = new FileStream(joinedFilePath, FileMode.Create, FileAccess.Write))
            {
                using (FileStream partOneStream = new FileStream(partOneFilePath, FileMode.Open, FileAccess.Read))
                {
                    int byteRead;

                    while ((byteRead = partOneStream.ReadByte()) != -1)
                    {
                        joinedStream.WriteByte((byte)byteRead);
                    }
                }

                using (FileStream partTwoStream = new FileStream(partTwoFilePath, FileMode.Open, FileAccess.Read))
                {
                    int byteRead;

                    while ((byteRead = partTwoStream.ReadByte()) != -1)
                    {
                        joinedStream.WriteByte((byte)byteRead);
                    }
                }
            }
        }
    }
}