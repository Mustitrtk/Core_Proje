using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Core_Proje.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager _portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            var values = _portfolioManager.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddPortfolio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPortfolio(Portfolio p) 
        { 
            PortfolioValidation validationRules = new PortfolioValidation();
            ValidationResult results = validationRules.Validate(p);
            if (results.IsValid)
            {
                _portfolioManager.TAdd(p);
                return RedirectToAction("Index");
            }
            else 
            {
                foreach(var item in results.Errors) 
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            
            return View()
        }
    }
}
