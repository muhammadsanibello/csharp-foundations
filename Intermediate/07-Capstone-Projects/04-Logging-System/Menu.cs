using System;

namespace LoggingSystem
{
    public static class Menu
    {
        public static string GetUserMenu()
        {
            return "1. Create Log\n2. View Logs\n3. Search Log\n4. Delete Log\n5. Statistics\n6. Undo Delete\n7. Process Queue\n8. Save Logs\n9. Load Logs\n0. Exit";
        }
    }
}
