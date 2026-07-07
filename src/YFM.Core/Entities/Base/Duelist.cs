using YFM.Core.Entities.Base;

namespace YFM.Core.Entities
{
    public class Duelist : EntityBase
    {
        public string Name { get; set; }

        public int Difficulty { get; set; }
    }
}
