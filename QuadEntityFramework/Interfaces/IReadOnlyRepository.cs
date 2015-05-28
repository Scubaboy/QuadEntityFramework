using System.Collections.Generic;

namespace QuadEntityFramework.Interfaces
{
    public interface IReadOnlyRepository<T> where T : class
    {
        IEnumerable<T> All{get;}
    }
}
