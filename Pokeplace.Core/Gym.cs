using System;

namespace Pokeplace.Core
{
    public class Gym : BaseDbEntity<Gym>
    {
        public string Nome { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public bool Ativo { get; set; }
    }
}
