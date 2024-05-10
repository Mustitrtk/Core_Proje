using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ExperienceManager : IGenericService<Experience>
    {
        IExperienceDal _experienceDal;
        public ExperienceManager(IExperienceDal experienceDal) 
        {
            _experienceDal = experienceDal;
        }

        public List<Experience> GetAll()
        {
            return _experienceDal.Get();
        }

        public Experience GetById(int id)
        {
            return _experienceDal.GetById(id);
        }

        public void TAdd(Experience t)
        {
            _experienceDal.Add(t);
        }

        public void TDelete(int id)
        {
            _experienceDal.DeleteById(id);
        }

        public void TUpdate(Experience t)
        {
            _experienceDal.Update(t);
        }
    }
}
