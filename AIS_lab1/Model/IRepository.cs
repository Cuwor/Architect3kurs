using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IRepository<T>
        where T: class, IDomainObject
    {
        ICollection<T> GetAll();
        T Get(int id);
        void Add(T obj);
        void Delete(T obj);

        void Update(T Obj);
    }
}
