using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace AspNetCoreFromScratch
{
    public static class DatabaseLoggerFactoryExtensions
    {
        public static ILoggerFactory AddDatabaseLogger(
            this ILoggerFactory loggerFactory, IConfiguration configuration
        )
        {
            DatabaseLoggingConfiguration loggingConfiguration =
                configuration.GetSection("Logging:Database")
                    .Get<DatabaseLoggingConfiguration>();
            
            return loggerFactory.AddDatabaseLogger(loggingConfiguration);
        }
        public static ILoggerFactory AddDatabaseLogger(this ILoggerFactory loggerFactory,
            DatabaseLoggingConfiguration loggingConfiguration)
        {
            loggerFactory.AddProvider(new DatabaseLoggerProvider(loggingConfiguration));

            return loggerFactory;
        }
    }
}