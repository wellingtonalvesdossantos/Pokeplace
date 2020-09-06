using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Pokeplace.Core
{
    public class BaseDbEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }

    public class BaseDbEntity<T> : BaseDbEntity where T : class
    {
        public static DbSet<T> ListAll()
        {
            return null;
        }

        public static T FetchById(int id)
        {
            return null;
        }
    }
}