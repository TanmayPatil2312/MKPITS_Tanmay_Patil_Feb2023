using connectioninsertitem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace connectioninsertitem.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {


            ViewBag.ItemList = "Computer Shop Item List Page";
            ItemDBHandler IHandler = new ItemDBHandler();
            ModelState.Clear();
            return View(IHandler.GetItemList());
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ItemModels iList)
        {

            if (ModelState.IsValid)
            {
                ItemDBHandler db = new ItemDBHandler();
                if (db.InsertItem(iList))

                {
                    ViewBag.Message = "Item Added Successfully";
                    ModelState.Clear();
                }
            }
            return View();

        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            ItemDBHandler ItemHandler = new ItemDBHandler();
            return View(ItemHandler.GetItemList().Find(itemmodel => itemmodel.ID == id));
        }
        [HttpPost]

        public ActionResult Edit(int id, ItemModels iList)
        {
            try
            {
                ItemDBHandler ItemHandler = new ItemDBHandler();
                ItemHandler.UpdateItem(iList);
                return RedirectToAction("Index");
            }
            catch { return View(); }
        }
        public ActionResult Delete(int id)
        {
            try
            {
                ItemDBHandler ItemHandler = new ItemDBHandler();
                if (ItemHandler.DeleteItem(id))
                {
                    ViewBag.AlertMsg = "Item Deleted Successfully";
                }
                return RedirectToAction("Index");
            }
            catch { return View(); }
        }
        public ActionResult Details(int id)
        {
            ItemDBHandler ItemHandler = new ItemDBHandler();
            return View(ItemHandler.GetItemList().Find(itemmodel => itemmodel.ID == id));
        }
    }
}



