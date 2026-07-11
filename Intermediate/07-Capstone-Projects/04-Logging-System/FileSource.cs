using System;

namespace LoggingSystem
{
    public static class FileSource
    {
        public static string GetFilePath()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string directoryName = "LogData";
            string directoryPath = Path.Combine(desktopPath, directoryName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string fileName = "logs.json";
            string filePath = Path.Combine(directoryPath, fileName);

            return filePath;
        }
     
    }
}
