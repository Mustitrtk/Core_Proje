using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager _featureManager = new FeatureManager(new EfFeatureDal());
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult addFeature()
        {
            return View();
        }

        [HttpGet]
        public IActionResult addFeature(Feature f)
        {
            FeatureValidator validationRules = new FeatureValidator();
            ValidationResult result = validationRules.Validate(f);
            if (result.IsValid)
            {
                _featureManager.TAdd(f);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }

        [HttpDelete]
        public IActionResult deleteFeature(int id) 
        { 
            _featureManager.TDelete(id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult updateFeature(int id) 
        { 
            var value = _featureManager.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult updateFeature(Feature f)
        {
            _featureManager.TUpdate(f);
            return RedirectToAction("Index");
        }
    }
}
