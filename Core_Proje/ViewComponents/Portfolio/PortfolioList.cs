using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Portfolio
{
    public class PortfolioList : ViewComponent
    {
        PortfolioManager _portfolioManager = new PortfolioManager(new EfPortfolio());
        public IViewComponentResult Invoke() 
        {
            var values = _portfolioManager.GetAll();
            return View(values);
        }
    }
}
