using Microsoft.AspNetCore.Mvc;
using RecapMVC.Models;

namespace RecapMVC.Controllers
{
    public class Employee : Controller
    {
        public IActionResult Index()
        {
            var context = new EmployeeDBContext();
            var model = context.Employees.ToList();
            return View(model);
        }

        public IActionResult OnFind(int id)
        {
            var context = new EmployeeDBContext();
            var record = context.Employees.FirstOrDefault(r=>r.EmpID==id);
            if(record == null)
            {
                throw new Exception("No record found");
            }
            return View(record);

        }
        [HttpPost]
        public IActionResult OnFind(RecapMVC.Models.Employee Pdata) 
        {
            var context = new EmployeeDBContext();
            var rec =  context.Employees.FirstOrDefault(rec => rec.EmpID ==Pdata.EmpID );
            if (rec != null)
            {
                rec.EmpID = Pdata.EmpID;
                rec.EmpName = Pdata.EmpName;
                rec.Email = Pdata.Email;
                rec.Salary = Pdata.Salary;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(null);
            }
        }

        public IActionResult OnDelete(int id)
        {
            var context = new EmployeeDBContext();
            var record = context.Employees.FirstOrDefault(rec => rec.EmpID == id);
            if(record != null)
            {
                context.Remove(record);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(null);
            }
        }

        
        public IActionResult OnAdd()
        {
            var context = new RecapMVC.Models.Employee();
            return View(context);

        }


        [HttpPost]
        public IActionResult OnAdd(RecapMVC.Models.Employee Pdata)
        {
            var context = new EmployeeDBContext();
            context.Employees.Add(Pdata);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
