using Evenoddmvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Evenoddmvc.Controllers
{
    public class EvenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Even e)
        {
            int num = e.n1;
            string res = "";
            if(num % 2 == 0)
            {
                res = "even";
            }
            else
            {
                res = "odd";
            }
            ViewBag.result = res;
            return View();
        }
    }
}
