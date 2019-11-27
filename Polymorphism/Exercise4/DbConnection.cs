using System;

namespace Exercise4
{
    public abstract class DbConnection
    {
        private string _connectionString;
        private readonly TimeSpan _timeOut;

        protected DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new NullReferenceException();

            _connectionString = connectionString;
            _timeOut = TimeSpan.FromMinutes(2);
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}