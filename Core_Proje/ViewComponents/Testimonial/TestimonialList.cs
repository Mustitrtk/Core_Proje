using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Testimonial
{
    public class TestimonialList : ViewComponent
    {
        TestimonialManager _testimonialManager = new TestimonialManager(new EfTestimonialDal());
        public IViewComponentResult Invoke() 
        {
            var values = _testimonialManager.GetAll();
            return View(values);
        }
    }
}
