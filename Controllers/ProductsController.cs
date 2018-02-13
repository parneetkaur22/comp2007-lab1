using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
          // Get: Products/details?acer=[value]
          public ActionResult Details(string acer)
        {
            // check for an empty acer
            if (acer == null)
            {
                //return View("Error");
                return RedirectToAction("Index");
            }

            ViewBag.Acer = acer;
            return View();
        }
    }
}