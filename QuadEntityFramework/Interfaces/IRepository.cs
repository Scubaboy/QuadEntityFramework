using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadEntityFramework.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T item);
        void Clear();
        IEnumerable<T> All{get;}
        void Remove(T item);
        void Save();
        void Update(T item);
    }
}
