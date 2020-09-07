using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using Pokeplace.Core.ExtensionMethods;

namespace Pokeplace.Core
{
    public class BaseDbEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }

    public class BaseDbEntity<T> : BaseDbEntity where T : BaseDbEntity
    {
        public static IQueryable<T> ListAll(params string[] dependencies)
        {
            var context = BaseDbContext.GetInstance().MainContext;
            return context.Set<T>().Include(dependencies);
        }

        public static T FetchById(int id, params string[] dependencies)
        {
            return ListAll(dependencies).FirstOrDefault(x => x.Id == id);
        }

        public void Add()
        {
            var context = BaseDbContext.GetInstance().MainContext;
            context.Entry(this).State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update()
        {
            var context = BaseDbContext.GetInstance().MainContext;
            context.Entry(this).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete()
        {
            var context = BaseDbContext.GetInstance().MainContext;
            context.Entry(this).State = EntityState.Deleted;
            context.SaveChanges();
        }
    }
}