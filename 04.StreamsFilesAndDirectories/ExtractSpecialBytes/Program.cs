
namespace ExtractSpecialBytes
{
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";
            // string binaryFilePath = @"./example.png";
            // string bytesFilePath = @"./bytes.txt";
            // string outputPath = @"./output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            List<byte> bytes = new List<byte>();
            using (StreamReader reader = new StreamReader(bytesFilePath))
            {
                while (!reader.EndOfStream)
                {
                    byte currentByte = byte.Parse(reader.ReadLine());
                    bytes.Add(currentByte);
                }
            }
            using (FileStream stream = new FileStream(binaryFilePath, FileMode.Open))
            {
                byte[] data = new byte[stream.Length];
                stream.Read(data, 0, data.Length);

                using (FileStream fs = new FileStream("output.bin", FileMode.Create, FileAccess.Write))
                using (BinaryWriter bw = new BinaryWriter(fs))
                    for (int i = 0; i < data.Length; i++)
                    {
                        byte currentByte = data[i];
                        if (bytes.Contains(currentByte))
                        {
                            bw.Write(currentByte);
                        }
                    }
            }
        }
    }
}
