using System;

namespace Todo_App
{
    public static class UtilityClass
    {
        public static bool ValidateInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input) || !input.All(char.IsDigit))
            {
                // Invalid input
                return false;
            }

            // Valid input
            return true;
        }

        public static string GetFilePath()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string folderPath = Path.Combine(desktopPath, "TaskData");

            Directory.CreateDirectory(folderPath);

            return Path.Combine(folderPath, "tasks.json");
        }
    }
}