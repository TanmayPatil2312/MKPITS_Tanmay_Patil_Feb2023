using DBConListClass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBConListClass.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item

        // 2 . ------Add New Item----
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create (ItemModel Ilist)
        {
            //try
            if(ModelState.IsValid)
            {
                ItemDBHandler ItemHandler = new ItemDBHandler();
                if(ItemHandler.InsertItem(Ilist))
                {
                    ViewBag.Message = "Item Added Successfully";
                    ModelState.Clear();
                }
            }
            return View();  
        }
    }
}