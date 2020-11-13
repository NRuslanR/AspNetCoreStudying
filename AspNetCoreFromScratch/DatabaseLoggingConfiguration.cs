using Microsoft.Extensions.Logging;

namespace AspNetCoreFromScratch
{
    public class DatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string TableName { get; set; }
        public string ProviderName { get; set; }
    }
    public class DatabaseLoggingConfiguration
    {
        public LogLevel LogLevel { get; set; }
        public EventId EventId { get; set; }
        public DatabaseSettings DatabaseSettings { get; set; }
        
    }
}