
namespace DirectoryTraversal
{
    using System;
    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            Dictionary<string, List<FileInfo>> fileDictionary = TraverseDirectory(path);

            WriteReportToDesktop(fileDictionary, reportFileName);
        }

        public static Dictionary<string, List<FileInfo>> TraverseDirectory(string inputFolderPath)
        {
            Dictionary<string, List<FileInfo>> fileDictionary = new();
            string[] files = Directory.GetFiles(inputFolderPath);
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                if (fileInfo.Exists)
                {
                    string extension = fileInfo.Extension;
                    if (!fileDictionary.ContainsKey(extension))
                    {
                        fileDictionary[extension] = new List<FileInfo>();
                    }
                    fileDictionary[extension].Add(fileInfo);
                }
            }
            return fileDictionary;
        }

        public static void WriteReportToDesktop(Dictionary<string, List<FileInfo>> fileDictionary, string reportFileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (var kvp in fileDictionary.OrderByDescending(item => item.Value.Count).ThenBy(item => item.Key))
                {
                    writer.WriteLine($"{kvp.Key}");
                    foreach (FileInfo file in kvp.Value.OrderByDescending(file => file.Length))
                    {
                        writer.WriteLine($"--{file.Name} - {(double)file.Length / 1024}kb");
                    }
                }
            }
        }
    }
}
