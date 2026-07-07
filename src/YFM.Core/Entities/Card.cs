using System.Collections.Generic;
using YFM.Core.Enums;
using YFM.Core.ValueObjects;

namespace YFM.Core.Entities
{
    public class Card
    {
        public CardId Id { get; set; }

        public int RomId { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Level { get; set; }

        public int Attack { get; set; }

        public int Defense { get; set; }

        public Attribute Attribute { get; set; }

        public MonsterType MonsterType { get; set; }

        public CardKind Kind { get; set; }

        public IReadOnlyList<GuardianStar> GuardianStars { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Attack}/{Defense})";
        }
    }
}
