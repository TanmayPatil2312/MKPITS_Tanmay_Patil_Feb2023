using Microsoft.AspNetCore.Mvc;
using validation2.Models;

namespace validation2.Controllers
{
    public class StudentModelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Index(StudentModel sm)
        {
            if(ModelState.IsValid)
            {
                ViewBag.Name = sm.Name;
                ViewBag.Email = sm.Email;
                ViewBag.Age = sm.Age;
                return View("Index");
            }
            else
            {
                ViewBag.Name = "No Data";
                ViewBag.Email = "No Data";
                ViewBag.Age = "No Data";
                return View("Index");
            }
        }
    }
}
