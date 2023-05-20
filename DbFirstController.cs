using Microsoft.AspNetCore.Mvc;
using RecapMVC.Models;

namespace RecapMVC.Controllers
{
    public class DbFirstController : Controller
    {
        DBFirstComponent context = new DBFirstComponent();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetEmployee()
        {
            var model = context.GetEmployeeList();
            return View(model);
        }
    }
     
}
