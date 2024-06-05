using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult PartialSidebar()
        {
            return PartialView();
        }
    }
}
