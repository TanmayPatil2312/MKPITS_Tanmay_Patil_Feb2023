using Microsoft.AspNetCore.Mvc;

namespace mvc_exm2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
