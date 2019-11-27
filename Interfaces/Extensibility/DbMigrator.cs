using System;

namespace Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo($"Migration started {DateTime.Now}");
            //code code code..........
            _logger.LogInfo($"Migration finished {DateTime.Now}");
        }
    }

}