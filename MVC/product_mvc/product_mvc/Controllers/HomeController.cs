using Microsoft.AspNetCore.Mvc;
using product_mvc.Models;
using System.Diagnostics;

namespace product_mvc.Controllers
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
        public IActionResult Index(Customer c)
        {
            ViewBag.orderno = c.orderno;
            ViewBag.customername = c.customername;
            ViewBag.price = c.price;
            ViewBag.qty = c.qty;
            int total = c.price * c.qty;
            var SelectedValue = c.getprd;
            ViewBag.prd = SelectedValue.ToString();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}