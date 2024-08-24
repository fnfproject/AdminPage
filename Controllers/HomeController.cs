using Microsoft.AspNetCore.Mvc;

namespace AdminSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult TrainerLogin()
        {
            return View();
        }
    }
}
