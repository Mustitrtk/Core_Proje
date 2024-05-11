using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Feature
{
    public class FeatureList : ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal()); //Constructer bir efDal öğesi istiyor.
        public IViewComponentResult Invoke() 
        {
            var values = featureManager.GetAll();
            return View(values); 
        }
    }
}
