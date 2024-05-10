using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public void Add(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        public void DeleteById(int id)
        {
            using var c = new Context();
            var item = c.Set<T>().Find(id);
            c.Set<T>().Remove(item);
            c.SaveChanges();
        }

        public List<T> Get()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);
        }

        public void Update(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
