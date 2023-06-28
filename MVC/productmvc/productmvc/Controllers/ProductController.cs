using Microsoft.AspNetCore.Mvc;
using productmvc.Models;

namespace productmvc.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Product p)
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
