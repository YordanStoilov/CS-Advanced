namespace LineNumbers
{
    using System;
    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"./text.txt";
            string outputFilePath = @"./output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(inputFilePath))
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                while (!reader.EndOfStream)
                {
                    char[] punctuationMarks = new char[] { '.', ',', '!', '?', '-', ';', ':', '(', ')', '\'', '"' };
                    string line = reader.ReadLine();
                    int punctuationCount = 0;
                    int charsCount = 0;

                    foreach (char character in line)
                    {
                        if (character == ' ')
                        {
                            continue;
                        }
                        if (punctuationMarks.Contains(character))
                        {
                            punctuationCount++;
                        }
                        else
                        {
                            charsCount++;
                        }
                    }
                    count++;
                    writer.WriteLine($"Line {count}: {line} ({charsCount})({punctuationCount})");
                }
            }
        }
    }
}