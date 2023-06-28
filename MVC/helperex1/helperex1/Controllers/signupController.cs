using helperex1.Models;
using Microsoft.AspNetCore.Mvc;

namespace helperex1.Controllers
{
    public class signupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(signup s)
        {
            ViewBag.username=s.username;
            ViewBag.password=s.password;
            return View();

        }

      
    }
}
