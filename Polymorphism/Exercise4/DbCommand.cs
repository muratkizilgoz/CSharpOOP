using System;

namespace Exercise4
{
    public class DbCommand
    {
        private readonly DbConnection _connection;

        public DbCommand(DbConnection connection)
        {
            _connection = connection ?? throw new InvalidOperationException();

        }

        public void Execute()
        {
            Console.WriteLine($"Connection {_connection}");
            _connection.OpenConnection();
            Console.WriteLine("Olaylar olaylar");
            _connection.CloseConnection();
        }
    }
}