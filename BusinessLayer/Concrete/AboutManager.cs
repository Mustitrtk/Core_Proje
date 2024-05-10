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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal) {
            _aboutDal = aboutDal;
        }

        public List<About> GetAll()
        {
            return _aboutDal.Get();
        }

        public About GetById(int id)
        {
            return _aboutDal.GetById(id);
        }

        public void TAdd(About t)
        {
            _aboutDal.Add(t);
        }

        public void TDelete(int id)
        {
            _aboutDal.DeleteById(id);
        }

        public void TUpdate(About t)
        {
            throw new NotImplementedException();
        }
    }
}
