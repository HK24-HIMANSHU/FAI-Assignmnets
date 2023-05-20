using Microsoft.AspNetCore.Mvc;

namespace RecapMVC.Controllers
{
    public class SinglePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
