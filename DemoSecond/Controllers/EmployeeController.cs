using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DemoSecond.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]

        public IActionResult EmployeeDetails()
        {
            List<string> Departments = new List<string>()
            {
                "HR" , "Admin" , "Development" , "Testing" , "Sales"
            };

            ViewData["Departments"] = new SelectList(Departments);
            return View();
        }
        [HttpPost]
        public IActionResult EmployeeDetails(IFormCollection form)
        {
            ViewBag.EmpId = form["EmpId"];
            ViewBag.Name = form["Name"];
            ViewBag.Gender = form["gender"];
            ViewBag.Departments = form["Departments"];
            ViewBag.Salary = form["Salary"];
            return View("DisplayEmpDetails");
        }
    }
}
