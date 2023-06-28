using Microsoft.AspNetCore.Mvc;
using mvchelperex2.Models;

namespace mvchelperex2.Controllers
{
    public class CalculatorModalController : Controller
    {
        // GET: Calculate
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(CalculatorModal cm)
        {
            int n1 = cm.num1;
            int n2 = cm.num2;
            int res = n1 + n2;
            ViewBag.result = res;
            return View();

            
        }
    }
}

