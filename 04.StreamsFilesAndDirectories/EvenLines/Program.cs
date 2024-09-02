
namespace EvenLines
{
    using System;

    public class EvenLines
    {
        static void Main()
        {
            // string inputFilePath = @"..\..\..\text.txt";
            string inputFilePath = @"./text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            List<string> output = new();
            char[] charsToReplace = new char[] { '-', ',', '.', '!', '?', };
            char charToReplaceWith = '@';

            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                int count = 0;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (count++ % 2 == 0)
                    {
                        Stack<string> textStack = new();

                        foreach (char character in charsToReplace)
                        {
                            line = line.Replace(character, charToReplaceWith);
                        }

                        string[] lineSplit = line.Split();
                        foreach (string word in lineSplit)
                        {
                            textStack.Push(word);
                        }
                        output.Add(string.Join(" ", textStack));
                    }
                }
            }
            return string.Join("\n", output);
        }
    }
}
