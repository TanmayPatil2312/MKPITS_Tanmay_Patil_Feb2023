using DBconnectionwithmvc.Models;
using Microsoft.AspNetCore.Mvc;


namespace DBconnectionwithmvc.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(ItemModel ilist)
        {
            if(ModelState.IsValid)
            {
                ItemDBHandler db = new ItemDBHandler();
                if(db.InsertIItem(ilist))
                {
                    ViewBag.message = "item saved Suceesfully";
                    ModelState.Clear();
                }
            }
            return View();

        }
    }
}
