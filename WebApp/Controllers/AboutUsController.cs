using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class AboutUsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       
    }
}
