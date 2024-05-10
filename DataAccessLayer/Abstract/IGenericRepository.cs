using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> Get();
        T GetById(int id);
        void Add(T t);
        void Update(T t);
        void DeleteById(int id);
    }
}
