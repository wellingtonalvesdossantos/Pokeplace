using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Text;

namespace Pokeplace.Core
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
            
        }

        public DatabaseContext()
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Gym>();
            modelBuilder.Entity<Pokemon>();
            modelBuilder.Entity<PokemonType>();
            modelBuilder.Entity<Pokestop>();
            modelBuilder.Entity<PrivacityLevel>();
            modelBuilder.Entity<Raid>();
            modelBuilder.Entity<RaidBoss>();
            modelBuilder.Entity<RaidMember>();
            modelBuilder.Entity<Team>();
            modelBuilder.Entity<Trainer>();
            modelBuilder.Entity<TrainerConfig>();
        }
    }
}
