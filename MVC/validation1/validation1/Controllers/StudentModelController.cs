using Microsoft.AspNetCore.Mvc;
using validation1.Models;

namespace validation1.Controllers
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
            if (string.IsNullOrEmpty(sm.name))
            {
                ModelState.AddModelError("Name", "Name Required");
            }
            if(sm.age == 0 || sm.age > 120)
            {
                ModelState.AddModelError("Age", "Please Enter Valid Age Between 1 - 100");

            }
            if(ModelState.IsValid)
            {
                ViewBag.name = sm.name;
                ViewBag.age = sm.age;
                return View("Index");
            }
            else
            {
                ViewBag.name = "No Data";
                ViewBag.age = "No Data";
                return View("Index");
            }
        }

    }
}
