using System;
using System.Timers;

namespace Exercise4
{
    public class SqlConnection:DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
            
        }

        public override void OpenConnection()
        {
            Console.WriteLine("SqlConnection Open");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Sql Connection Close");
        }
    }
}