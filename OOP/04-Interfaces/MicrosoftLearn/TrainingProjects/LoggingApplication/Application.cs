using System;

namespace LoggingApplication
{
    public class Application
    {
        private readonly ILogger _logger;
        private readonly IDataAccess _dataAccess;

        public Application(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }
    }
}
