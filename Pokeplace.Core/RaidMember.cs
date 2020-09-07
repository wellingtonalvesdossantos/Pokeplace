using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Pokeplace.Core
{
    public class RaidMember : BaseDbEntity<RaidMember>
    {
        public DateTime Registro { get; set; }
        [ForeignKey("Raid")]
        public int RaidId { get; set; }
        [ForeignKey("Trainer")]
        public int TrainerId { get; set; }
        public bool PrecisaConvite { get; set; }
        [ForeignKey("ConviteTrainer")]
        public int? ConviteTrainerId { get; set; }

        public virtual Raid Raid { get; set; }
        public virtual Trainer Trainer { get; set; }
        public virtual Trainer ConviteTrainer { get; set; }

    }
}
