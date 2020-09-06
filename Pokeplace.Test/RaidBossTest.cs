using NUnit.Framework;
using Pokeplace.Core;
using System.Linq;

namespace Pokeplace.Test
{
    public class RaidBossTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            var sqlConnectionStringBuilder = new System.Data.SqlClient.SqlConnectionStringBuilder()
            {
                DataSource = ".",
                InitialCatalog = "Pokeplace",
                IntegratedSecurity = true
            };
            databaseContext = new DatabaseContext(sqlConnectionStringBuilder.ConnectionString);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}