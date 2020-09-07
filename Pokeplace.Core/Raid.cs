using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Pokeplace.Core
{
    public class Raid : BaseDbEntity<Raid>
    {
        public DateTime Inicio { get; set; }
        [ForeignKey("Gym")]
        public int GymId { get; set; }
        public DateTime Registro { get; set; }
        [ForeignKey("Trainer")]
        public int TrainerId { get; set; }
        [ForeignKey("RaidBoss")]
        public int? RaidBossId { get; set; }

        public virtual List<RaidMember> Members { get; set; }

        public virtual Gym Gym { get; set; }
        public virtual Trainer Trainer { get; set; }
        public virtual RaidBoss RaidBoss { get; set; }
    }
}
