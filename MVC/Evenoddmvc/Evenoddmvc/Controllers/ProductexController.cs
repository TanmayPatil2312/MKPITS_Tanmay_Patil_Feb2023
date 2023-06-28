using Evenoddmvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Evenoddmvc.Controllers
{
    public class ProductexController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(product p)
        {
            ViewBag.name = p.name;
            int pr = p.price;
            int qt = p.qty;
            int res = pr * qt;
            ViewBag.result = res;
            return View();
        }
    }
}
