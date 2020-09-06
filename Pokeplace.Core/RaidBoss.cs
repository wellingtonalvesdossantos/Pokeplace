using System;
using System.Collections.Generic;
using System.Text;

namespace Pokeplace.Core
{
    public class RaidBoss : BaseDbEntity
    {
        public int PokemonId { get; set; }
        public bool Ativo { get; set; }
        public int? CP { get; set; }
    }
}
