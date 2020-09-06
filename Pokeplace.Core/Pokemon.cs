using System;
using System.Collections.Generic;
using System.Text;

namespace Pokeplace.Core
{
    public class Pokemon : BaseDbEntity
    {
        public string Nome { get; set; }
        public int Numero { get; set; }
        public int MainTypeId { get; set; }
        public int? SecondTypeId { get; set; }
        public int? ATK { get; set; }
        public int? DEF { get; set; }
        public int? STA { get; set; }
    }
}
