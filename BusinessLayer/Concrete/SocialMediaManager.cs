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
    public class SocialMediaManager : IGenericService<SocialMedia>
    {
        ISocialMediaDal _socialMediaDal;
        public SocialMediaManager(ISocialMediaDal socialMediaDal) 
        { 
            _socialMediaDal = socialMediaDal;
        }
        public List<SocialMedia> GetAll()
        {
            return _socialMediaDal.Get();
        }

        public SocialMedia GetById(int id)
        {
            return _socialMediaDal.GetById(id);
        }

        public void TAdd(SocialMedia t)
        {
            _socialMediaDal.Add(t);
        }

        public void TDelete(int id)
        {
            _socialMediaDal.DeleteById(id);
        }

        public void TUpdate(SocialMedia t)
        {
            _socialMediaDal.Update(t);
        }
    }
}
