using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Contact
{
    public class ContactList : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
