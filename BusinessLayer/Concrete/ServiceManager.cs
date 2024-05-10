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
    public class ServiceManager : IGenericService<Service>
    {
        IServiceDal _serviceDal;
        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public List<Service> GetAll()
        {
            return _serviceDal.Get();
        }

        public Service GetById(int id)
        {
            return _serviceDal.GetById(id);
        }

        public void TAdd(Service t)
        {
            _serviceDal.Add(t);
        }

        public void TDelete(int id)
        {
            _serviceDal.DeleteById(id);
        }

        public void TUpdate(Service t)
        {
            _serviceDal.Update(t);
        }
    }
}
