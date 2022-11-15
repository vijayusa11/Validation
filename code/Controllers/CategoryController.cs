using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace code.Controllers
{
    public class CategoryController : Controller
    {
        WebAppEntities db = new WebAppEntities();
        // GET: Category
        [HttpGet]
        public ActionResult Index()
        {
            var category = db.tbl_category.ToList();
            return View(category);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(tbl_category category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.tbl_category.Add(category);
                    db.SaveChanges();

                    TempData["msg"] = "Category Added Successfully";
                    return RedirectToAction("Create");
                }
                else
                {
                    return View();
                }
            }
            catch(Exception ex)
            {
                TempData["msg"] = "Category Added Successfully" + ex.Message;
                return RedirectToAction("Create");
            }
           
        }
    }
}