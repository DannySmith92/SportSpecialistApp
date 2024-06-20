using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class OurTeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
