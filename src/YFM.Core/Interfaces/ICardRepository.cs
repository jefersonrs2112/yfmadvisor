using System.Collections.Generic;
using YFM.Core.Entities;
using YFM.Core.ValueObjects;

namespace YFM.Core.Interfaces
{
    public interface ICardRepository
    {
        Card Get(CardId id);

        Card Get(string name);

        IReadOnlyCollection<Card> GetAll();
    }
}
