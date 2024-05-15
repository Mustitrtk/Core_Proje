using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult MessagePartial() { return PartialView(); }

        [HttpPost]
        public PartialViewResult MessagePartial(Message m)
        {

            MessageManager _messageManager = new MessageManager(new EfMessageDal());

            m.Date = DateTime.Now.Date;
            m.Status = true;
            _messageManager.TAdd(m);
            return PartialView();
        }
    }
}
