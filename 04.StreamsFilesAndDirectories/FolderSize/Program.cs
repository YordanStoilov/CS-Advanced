
namespace FolderSize
{
    public class FolderSize
    {
        static void Main()
        {
            // string folderPath = @"..\..\..\Files\TestFolder";
            // string outputPath = @"..\..\..\Files\output.txt";
            string folderPath = @"/Users/yordanstoilov/Desktop/headrush/Coding/CSAdvancedMain/CSAdvanced/04.StreamsFilesAndDirectories/FolderSize/TestFolder/";
            string outputPath = @"/Users/yordanstoilov/Desktop/headrush/Coding/CSAdvancedMain/CSAdvanced/04.StreamsFilesAndDirectories/FolderSize/output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                writer.WriteLine($"{ReadFolder(folderPath) / 1000.0}");
            }
        }
        public static double ReadFolder(string folderPath)
        {
            string[] files = Directory.GetFiles(folderPath);
            double size = 0;

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                size += fileInfo.Length;
            }
            string[] directories = Directory.GetDirectories(folderPath);

            foreach (var dir in directories)
            {
                size += ReadFolder(dir);
            }
            return size;
        }
    }
}
