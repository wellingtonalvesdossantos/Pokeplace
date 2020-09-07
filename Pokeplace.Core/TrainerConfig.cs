using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Pokeplace.Core
{
    public class TrainerConfig : BaseDbEntity<TrainerConfig>
    {
        [ForeignKey("Trainer")]
        public int TrainerId { get; set; }
        public bool DisponivelRaidPresencial { get; set; }
        public bool DisponivelRaidRemota { get; set; }
        public int CelularPrivacityLevelId { get; set; }
        public int EmailPrivacityLevelId { get; set; }

        public virtual Trainer Trainer { get; set; }

        public static TrainerConfig FetchByTrainerId(int trainerId, params string[] dependencies)
        {
            return ListAll(dependencies).FirstOrDefault(x => x.TrainerId == trainerId);
        }

    }
}
