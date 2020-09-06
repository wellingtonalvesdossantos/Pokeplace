using System;
using System.Collections.Generic;
using System.Text;

namespace Pokeplace.Core
{
    public class RaidMember : BaseDbEntity
    {
        public DateTime Registro { get; set; }
        public int TrainerId { get; set; }
        public bool PrecisaConvite { get; set; }
        public int? ConviteTrainerId { get; set; }
    }
}
