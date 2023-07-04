using Microsoft.AspNetCore.Mvc;
using signupform.Models;
using System.Diagnostics;

namespace signupform.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Index(Signup u)
        {
            ViewBag.username = u.username;
            ViewBag.password = u.password;
            ViewBag.email = u.email;
            ViewBag.gender = u.gender;
            ViewBag.subject1 = null;
            ViewBag.subject2 = null;
            if (u.subject1 == true)
            {
                ViewBag.subject1 = "dotnet";
            }
            if (u.subject2 == true)
            {
                ViewBag.subject2 = "java";
            }

            return View();
        }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            
            public IActionResult Error()
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
    }
