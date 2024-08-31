namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            Dictionary<string, int> wordOccurences = new();
            using (StreamReader reader = new StreamReader(@"./words.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string[] words = reader.ReadLine().Split();
                    foreach (string word in words)
                    {
                        wordOccurences[word] = 0;
                    }
                }
            }
            using (StreamReader reader = new StreamReader(@"./text.txt"))
            {
                char[] delimiters = new char[] { ',', '.', '!', '?', '-', ' ' };
                while (!reader.EndOfStream)
                {
                    string[] words = reader.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string word in words)
                    {
                        foreach (var kvp in wordOccurences)
                        {
                            if (word.Contains(kvp.Key))
                            {
                                wordOccurences[kvp.Key]++;
                            }
                        }
                    }
                }
            }
            Dictionary<string, int> sorted = wordOccurences.OrderByDescending(kvp => kvp.Value).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            using (StreamWriter writer = new StreamWriter(@"./output.txt"))
            {
                foreach (var (word, occurences) in sorted)
                {
                    writer.WriteLine($"{word} - {occurences}");
                }
            }
        }
    }
}
