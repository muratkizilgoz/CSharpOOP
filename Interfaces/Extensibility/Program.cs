using System;

namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open Close 

            var dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Migrate();

            dbMigrator = new DbMigrator(new FileLogger(@"C:\Test\log.txt"));
            dbMigrator.Migrate();
        }
    }
}
