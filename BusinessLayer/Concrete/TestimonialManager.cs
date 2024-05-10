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
    public class TestimonialManager : IGenericService<Testimonial>
    {
        ITestimonialDal _testimonialDal;
        public TestimonialManager(ITestimonialDal testimonialDal) 
        { 
            _testimonialDal = testimonialDal;
        }
        public List<Testimonial> GetAll()
        {
            return _testimonialDal.Get();
        }

        public Testimonial GetById(int id)
        {
            return _testimonialDal.GetById(id);
        }

        public void TAdd(Testimonial t)
        {
            _testimonialDal.Add(t);
        }

        public void TDelete(int id)
        {
            _testimonialDal.DeleteById(id);
        }

        public void TUpdate(Testimonial t)
        {
            _testimonialDal.Update(t);
        }
    }
}
