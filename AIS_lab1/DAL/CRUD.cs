using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;

namespace SqlDAL
{
    public abstract class CRUD<T>: IRepository<T>
        where T : class, IDomainObject
    {
        public string ConnectionString { get; set; }

        public abstract ICollection<T> GetAll();

        public abstract T Get(int id);

        public abstract void Update(T Obj);

        public abstract void Add(T obj);

        public abstract void Delete(T obj);
    }
}
