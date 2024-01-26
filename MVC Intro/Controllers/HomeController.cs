using Microsoft.AspNetCore.Mvc;

namespace MVC_Intro.Controllers
{
    public class HomeController : Controller
    {

        public ContentResult ContentResult()
        {
            return Content("Hello BB206");
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult actionResult()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
