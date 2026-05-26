using System;

namespace LoggingApplication
{
    public interface IDataAccess
    {
        // Connect to the data source.
        void Connect();

        // Retrieves data from the data source.
        string GetData();
    }
}
