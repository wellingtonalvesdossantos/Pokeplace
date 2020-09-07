using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Pokeplace.Core
{
    public class RaidBoss : BaseDbEntity<RaidBoss>
    {
        [ForeignKey("Pokemon")]
        public int PokemonId { get; set; }
        public bool Ativo { get; set; }
        public int? CP { get; set; }

        public virtual Pokemon Pokemon { get; set; }
    }
}
