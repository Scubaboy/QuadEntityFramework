using System.Collections.Generic;

namespace QuadEntityFramework.Interfaces
{
    public interface IReadUpdateOnlyRepository<T> where T : class
    {
        IEnumerable<T> All {get;}
        void Update(T item);
        void Save();
    }
}
