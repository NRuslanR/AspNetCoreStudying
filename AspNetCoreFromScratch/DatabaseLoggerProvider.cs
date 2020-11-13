using System.Collections.Concurrent;
using Microsoft.Extensions.Logging;

namespace AspNetCoreFromScratch
{
    public class DatabaseLoggerProvider : ILoggerProvider
    {
        private DatabaseLoggingConfiguration _loggingConfiguration;
        private ConcurrentDictionary<string, ILogger> _loggers;

        public DatabaseLoggerProvider(DatabaseLoggingConfiguration loggingConfiguration)
        {
            _loggingConfiguration = loggingConfiguration;
            
            _loggers = new ConcurrentDictionary<string, ILogger>();
        }
        
        public void Dispose()
        {
            _loggers.Clear();
        }

        public ILogger CreateLogger(string categoryName)
        {
            return _loggers.GetOrAdd(categoryName, name => new DatabaseLogger(name, _loggingConfiguration));
        }
    }
}