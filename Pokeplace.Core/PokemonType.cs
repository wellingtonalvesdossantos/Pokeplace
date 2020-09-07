using System;

namespace Pokeplace.Core
{
    public class PokemonType : BaseDbEntity<PokemonType>
    {
        public string Nome { get; set; }
    }
}
