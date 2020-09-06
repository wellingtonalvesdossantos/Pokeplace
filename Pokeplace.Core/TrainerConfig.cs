using System;
using System.Collections.Generic;
using System.Text;

namespace Pokeplace.Core
{
    public class TrainerConfig : BaseDbEntity
    {
        public int TrainerId { get; set; }
        public bool DisponivelRaidPresencial { get; set; }
        public bool DisponivelRaidRemota { get; set; }
        public int CelularPrivacityLevelId { get; set; }
        public int EmailPrivacityLevelId { get; set; }
    }
}
