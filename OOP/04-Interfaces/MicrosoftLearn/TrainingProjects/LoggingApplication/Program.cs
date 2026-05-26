using LoggingApplication;

var logger = new ConsoleLogger();
var dataAccess = new DatabaseAccess();

// Inject the dependencies into the Application class.
var app = new Application(logger, dataAccess);