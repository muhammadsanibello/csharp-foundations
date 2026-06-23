using System;

namespace Contact_Manager
{
    public static class UtilityClass
    {
        public static string GetFilePath()
        {
            string appPath = AppDomain.CurrentDomain.BaseDirectory;
            string folderPath = Path.Combine(appPath, "ContactsData");

            Directory.CreateDirectory(folderPath);

            return Path.Combine(folderPath, "contacts.txt");
        }
    }
}
