using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class SkillController : Controller
    {
        SkillManager _skillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            var values = _skillManager.GetAll();
            return View(values);
        }
    }
}
