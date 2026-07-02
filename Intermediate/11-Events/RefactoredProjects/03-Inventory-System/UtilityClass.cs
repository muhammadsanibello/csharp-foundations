using System;

namespace Inventory_System
{
    public static class UtilityClass
    {
        public static string GetFilePath()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string folderPath = Path.Combine(desktopPath, "InventoryData");

            Directory.CreateDirectory(folderPath);

            return Path.Combine(folderPath, "inventory.json");
        }

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

        public static void ValidateProductId(string productId)
        {
            if (string.IsNullOrWhiteSpace(productId) || !productId.All(char.IsDigit))
            {
                throw new ArgumentException("Invalid ID!");
            }
        }
    }
}
