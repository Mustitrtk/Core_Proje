using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.SendMessage
{
    public class SendMessage : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
