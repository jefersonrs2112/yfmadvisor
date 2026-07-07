using YFM.Core.Entities.Base;

namespace YFM.Core.Entities
{
    public class Equip : EntityBase
    {
        public string Name { get; set; }

        public int AttackBonus { get; set; }

        public int DefenseBonus { get; set; }
    }
}
