
namespace SplitMergeBinaryFile
{
    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"./example.png";
            string joinedFilePath = @"./example-joined.png";
            string partOnePath = @"./part-1.bin";
            string partTwoPath = @"./part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            using (FileStream stream = new FileStream(sourceFilePath, FileMode.Open))
            {
                byte[] data = new byte[stream.Length];
                stream.Read(data, 0, data.Length);
                int firstHalfLength = 0;
                int secondHalfLength = 0;
                if (data.Length % 2 == 1)
                {
                    firstHalfLength = data.Length / 2 + 1;
                    secondHalfLength = data.Length / 2;
                }
                else
                {
                    firstHalfLength = data.Length / 2;
                    secondHalfLength = data.Length / 2;
                }
                using (FileStream firstHalfStream = new FileStream(partOneFilePath, FileMode.Create, FileAccess.Write))
                using (BinaryWriter bw = new BinaryWriter(firstHalfStream))
                {
                    for (int i = 0; i < firstHalfLength; i++)
                    {
                        byte currentByte = data[i];
                        bw.Write(currentByte);
                    }
                }
                using (FileStream secondHalfStream = new FileStream(partTwoFilePath, FileMode.Create, FileAccess.Write))
                using (BinaryWriter bw = new BinaryWriter(secondHalfStream))
                {
                    for (int i = firstHalfLength; i < data.Length; i++)
                    {
                        byte currentByte = data[i];
                        bw.Write(currentByte);
                    }
                }
            }
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            using (FileStream stream = new FileStream(partOneFilePath, FileMode.Open))
            {
                byte[] data = new byte[stream.Length];
                stream.Read(data, 0, data.Length);
                using (FileStream output = new FileStream(joinedFilePath, FileMode.Create, FileAccess.Write))
                using (BinaryWriter bw = new BinaryWriter(output))
                {
                    foreach (byte chunk in data)
                    {
                        bw.Write(chunk);
                    }
                }
            }
            using (FileStream stream = new FileStream(partTwoFilePath, FileMode.Open))
            {
                byte[] data = new byte[stream.Length];
                stream.Read(data, 0, data.Length);
                using (FileStream output = new FileStream(joinedFilePath, FileMode.Create, FileAccess.Write))
                using (BinaryWriter bw = new BinaryWriter(output))
                {
                    foreach (byte chunk in data)
                    {
                        bw.Write(chunk);
                    }
                }
            }
        }
    }
}
