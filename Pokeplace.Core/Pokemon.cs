using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Pokeplace.Core
{
    public class Pokemon : BaseDbEntity<Pokemon>
    {
        public string Nome { get; set; }
        public int Numero { get; set; }
        [ForeignKey("MainType")]
        public int MainTypeId { get; set; }
        [ForeignKey("SecondType")]
        public int? SecondTypeId { get; set; }
        public int? ATK { get; set; }
        public int? DEF { get; set; }
        public int? STA { get; set; }

        public virtual PokemonType MainType { get; set; }
        public virtual PokemonType SecondType { get; set; }
    }
}
