using Microsoft.AspNetCore.Mvc;

namespace mvc_ex1.Controllers
{
    public class StudentController1 : Controller
    {
        public IActionResult Student()
        {
            return View();
        }
    }
}
