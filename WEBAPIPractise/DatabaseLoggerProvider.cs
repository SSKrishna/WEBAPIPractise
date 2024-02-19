using Microsoft.Data.SqlClient;

namespace WEBAPIPractise
{
    public class DatabaseLoggerProvider : ILoggerProvider
    {

        private readonly string _connectionString;

        public DatabaseLoggerProvider(string connectionString)
        {
            _connectionString = connectionString;
        }
        public ILogger CreateLogger(string categoryName)
        {
            return new DatabaseLogger(_connectionString);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }



    public class DatabaseLogger : ILogger
    {

        private readonly string _connectionString;

        public DatabaseLogger(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDisposable BeginScope<TState>(TState state) => null;

        public bool IsEnabled(LogLevel logLevel) => true;


        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            if (logLevel == LogLevel.None)
                return;

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO Log (LogLevel, Message, Exception, Timestamp) VALUES (@LogLevel, @Message, @Exception, @Timestamp)";
                    command.Parameters.AddWithValue("@LogLevel", logLevel.ToString());
                    command.Parameters.AddWithValue("@Message", formatter(state, exception));
                    command.Parameters.AddWithValue("@Exception", exception?.ToString() ?? "");
                    command.Parameters.AddWithValue("@Timestamp", DateTime.UtcNow);
                    command.ExecuteNonQuery();
                }
            }
        }
    }

}
