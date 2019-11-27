using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            var sql = new SqlConnection("192.123231.1212Sql");
            sql.OpenConnection();
            sql.CloseConnection();
            
            var oracle = new OracleConnection("oracle121.12.2121.1");
            oracle.OpenConnection();
            oracle.CloseConnection();

            Console.WriteLine();

            var dbCommand = new DbCommand(sql);
            dbCommand.Execute();

            Console.WriteLine();

            var commandAnother = new DbCommand(oracle);
            commandAnother.Execute();
        }
    }
}
