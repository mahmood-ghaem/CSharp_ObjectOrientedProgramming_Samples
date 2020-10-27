using System;

namespace Interface_Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            this._logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("Migrating start at " + DateTime.Now);

            //Details of migrating the database

            _logger.LogInfo("Migrating finish at " + DateTime.Now);
        }
    }
}
