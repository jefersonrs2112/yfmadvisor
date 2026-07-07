using YFM.Core.Enums;

namespace YFM.Core.Entities
{
    public class CardGuardian
    {
        public int CardId { get; set; }

        public GuardianStar GuardianStar { get; set; }

        public int Order { get; set; }
    }
}
