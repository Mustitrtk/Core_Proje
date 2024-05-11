using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Service
{
    public class ServiceList : ViewComponent
    {
        ServiceManager _serviceManager = new ServiceManager(new EfServiceDal());
        public IViewComponentResult Invoke() 
        { 
            var values = _serviceManager.GetAll();
            return View(values); 
        }
    }
}
