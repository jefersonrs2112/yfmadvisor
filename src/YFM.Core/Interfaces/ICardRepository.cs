using YFM.Core.Entities;
using YFM.Core.ValueObjects;

namespace YFM.Core.Interfaces
{
    public interface ICardRepository : IRepository<Card>
    {
        Card Get(CardId id);

        Card Get(string name);

        Card GetByPassword(string password);
    }
}
