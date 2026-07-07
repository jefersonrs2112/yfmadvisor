using System.Collections.Generic;

namespace YFM.Core.Interfaces
{
    public interface IRepository<T>
    {
        T Get(int id);

        IReadOnlyCollection<T> GetAll();
    }
}
