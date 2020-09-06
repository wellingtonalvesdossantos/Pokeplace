using System;
using System.Collections.Generic;
using System.Text;

namespace Pokeplace.Core
{
    public class Raid : BaseDbEntity
    {
        public DateTime Inicio { get; set; }
        public int GymId { get; set; }
        public DateTime Registro { get; set; }
        public int TrainerId { get; set; }
        public int? RaidBossId { get; set; }
    }
}
