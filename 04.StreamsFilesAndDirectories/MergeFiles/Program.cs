
namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            string firstInputFilePath = @"./input1.txt";
            string secondInputFilePath = @"./input2.txt";
            string outputFilePath = @"./output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using (StreamReader reader1 = new StreamReader(firstInputFilePath))
            {
                using (StreamReader reader2 = new StreamReader(secondInputFilePath))
                {
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        List<string> pathsArray = new List<string>() { firstInputFilePath, secondInputFilePath };
                        string shortestReaderPath;
                        if (File.ReadLines(firstInputFilePath).Count() < File.ReadLines(secondInputFilePath).Count())
                        {
                            shortestReaderPath = firstInputFilePath;
                        }
                        else
                        {
                            shortestReaderPath = secondInputFilePath;
                        }
                        pathsArray.Remove(shortestReaderPath);
                        string longestReaderPath = pathsArray[0];
                        StreamReader writerLast = new StreamReader(longestReaderPath);

                        for (int i = 0; i < File.ReadLines(shortestReaderPath).Count(); i++)
                        {
                            writer.WriteLine(reader1.ReadLine());
                            writer.WriteLine(reader2.ReadLine());
                        }
                        for (int i = 0; i < File.ReadLines(shortestReaderPath).Count(); i++)
                        {
                            writerLast.ReadLine();
                        }
                        while (!writerLast.EndOfStream)
                        {
                            writer.WriteLine(writerLast.ReadLine());
                        }
                    }
                }
            }
        }
    }
}
