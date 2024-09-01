
namespace OddLines
{
    public class OddLines
    {
        static void Main()
        {

            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";
            // string inputFilePath = @"./input.txt";
            // string outputFilePath = @"./output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);

            void ExtractOddLines(string inputFilePath, string outputFilePath)
            {
                int count = 0;
                using (StreamReader reader = new StreamReader(inputFilePath))
                {
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            if (count % 2 == 1)
                            {
                                writer.WriteLine(line);
                            }
                            count++;
                        }
                    }

                }
            }

        }
    }
}