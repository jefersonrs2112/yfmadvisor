using YFM.Core.Entities.Base;
using System.Collections.Generic;

namespace YFM.Core.Entities
{
    public class FusionRule : EntityBase
    {
        public List<FusionOperand> Operands { get; }

        public int ResultCardId { get; set; }

        public FusionRule()
        {
            Operands = new List<FusionOperand>();
        }
    }
}
