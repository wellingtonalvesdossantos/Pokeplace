using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Pokeplace.Core
{
    public class BaseDbContext
    {
        private static BaseDbContext _instance = null;

        public DbContext MainContext { get; private set; }

        private BaseDbContext()
        {
            var sqlConnectionStringBuilder = new System.Data.SqlClient.SqlConnectionStringBuilder()
            {
                DataSource = ".",
                InitialCatalog = "Pokeplace",
                IntegratedSecurity = true
            };
            MainContext = new DatabaseContext(sqlConnectionStringBuilder.ConnectionString);
        }

        public static BaseDbContext GetInstance()
        {
            if (_instance == null)
                _instance = new BaseDbContext();

            return _instance;
        }
    }
}
