using YFM.Core.Enums;

namespace YFM.Core.Entities
{
    public class GuardianStarInfo
    {
        public GuardianStar Star { get; }

        public GuardianStarInfo(GuardianStar star)
        {
            Star = star;
        }

        public override string ToString()
        {
            return Star.ToString();
        }
    }
}
