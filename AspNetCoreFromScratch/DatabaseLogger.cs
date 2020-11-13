using System;
using Microsoft.Extensions.Logging;
using System.Data;
using System.Data.Common;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace AspNetCoreFromScratch
{
    public class DatabaseLogger : ILogger
    {
        private string _name;
        private readonly DatabaseLoggingConfiguration _loggingConfiguration;
        private IDbCommand _logWriteCommand;
        
        public DatabaseLogger(string name, DatabaseLoggingConfiguration databaseLoggingConfiguration)
        {
            _name = name;
            
            _loggingConfiguration = databaseLoggingConfiguration;

            _logWriteCommand = MakeLogWriteDbCommand(_loggingConfiguration.DatabaseSettings);
        }

        private IDbCommand MakeLogWriteDbCommand(DatabaseSettings database)
        {
            var providerFactory = DbProviderFactories.GetFactory(database.ProviderName);

            var connection = providerFactory.CreateConnection();

            connection.ConnectionString = database.ConnectionString;
            
            connection.Open();

            var command = providerFactory.CreateCommand();

            command.Connection = connection;
            command.CommandText =
                $"INSERT INTO {database.TableName} (log_level, event_id, message, creation_date) " +
                $"VALUES (@LogLevel, @EventId, @Message, @CreationDate)";

            var param = providerFactory.CreateParameter();

            param.DbType = DbType.String;
            param.ParameterName = "@LogLevel";

            command.Parameters.Add(param);

            param = providerFactory.CreateParameter();

            param.DbType = DbType.String;
            param.ParameterName = "@EventId";

            command.Parameters.Add(param);

            param = providerFactory.CreateParameter();

            param.DbType = DbType.String;
            param.ParameterName = "@Message";

            command.Parameters.Add(param);

            param = providerFactory.CreateParameter();

            param.DbType = DbType.DateTime;
            param.ParameterName = "@CreationDate";

            command.Parameters.Add(param);
            
            return command;
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return logLevel >= _loggingConfiguration.LogLevel;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if (!IsEnabled(logLevel))
                return;

            ((IDbDataParameter) _logWriteCommand.Parameters["@LogLevel"]).Value = logLevel.ToString();
            ((IDbDataParameter) _logWriteCommand.Parameters["@EventId"]).Value = eventId.ToString();
            ((IDbDataParameter) _logWriteCommand.Parameters["@Message"]).Value = $"{_name} - {formatter(state, exception)}";
            ((IDbDataParameter) _logWriteCommand.Parameters["@CreationDate"]).Value = DateTime.Now;

            _logWriteCommand.ExecuteNonQuery();
        }
    }
}