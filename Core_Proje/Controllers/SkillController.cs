using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using EntityLayer.Concrete;
using BusinessLayer.ValidationRules;
using FluentValidation;
using FluentValidation.Results;

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

        [HttpGet]
        public IActionResult AddSkill() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSkill(Skill skill) 
        {
            SkillValidation validator = new SkillValidation();
            ValidationResult result = validator.Validate(skill);
            if (result.IsValid) 
            {
                _skillManager.TAdd(skill);
                return RedirectToAction("Index");
            }
            else 
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }

        public IActionResult DeleteSkill(int id)
        {
            _skillManager.TDelete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditSkill(int id) 
        {
            var value = _skillManager.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult EditSkill(Skill skill) 
        {
            _skillManager.TUpdate(skill);
            return RedirectToAction("Index");
        }
    }
}
