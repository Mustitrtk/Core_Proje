using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager _experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            var values = _experienceManager.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddExperience() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddExperience(Experience e)
        {
            _experienceManager.TAdd(e);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperience(int id) 
        {
            _experienceManager.TDelete(id);
            return RedirectToAction("Index");
        }
    }
}
