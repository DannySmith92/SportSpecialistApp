using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class ClassesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
