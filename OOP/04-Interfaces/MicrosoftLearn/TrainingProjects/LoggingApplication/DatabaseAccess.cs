using System;

namespace LoggingApplication
{
    public class DatabaseAccess : IDataAccess
    {
        // Simulates connecting to a database.
        public void Connect()
        {
            Console.WriteLine("Database connected.");
        }

        // Simulates retrieving data from the database.
        public string GetData()
        {
            return "Sample Data from Database";
        }
    }
}
