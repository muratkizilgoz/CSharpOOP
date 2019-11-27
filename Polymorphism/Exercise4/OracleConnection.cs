using System;

namespace Exercise4
{
    public class OracleConnection:DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Oracle open");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Oracle close");
        }
    }
}