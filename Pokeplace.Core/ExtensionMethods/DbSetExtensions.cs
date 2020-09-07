using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Pokeplace.Core.ExtensionMethods
{
    public static class DbSetExtensions
    {
        public static IQueryable<T> Include<T>(this DbSet<T> dbSet, string[] dependencies) where T : BaseDbEntity
        {
            if (dependencies.HasResults())
            {
                var tmp = dbSet.Include(dependencies.First());
                foreach (var item in dependencies.Skip(1))
                {
                    tmp = tmp.Include(item);
                }
                return tmp;
            }
            else
            {
                return dbSet;
            }
        }
    }
}
