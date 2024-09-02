namespace LineNumbers
{
    using System;
    public class LineNumbers
    {
        static void Main()
        {
            // string inputFilePath = @"..\..\..\text.txt";
            // string outputFilePath = @"..\..\..\output.txt";
            string inputFilePath = @"./text.txt";
            string outputFilePath = @"./output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                char[] punctuationMarks = new char[] { '.', ',', '!', '?', '-', ';', ':', '(', ')', '\'', '"' };
                int count = 1;
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
            }
        }
    }
}