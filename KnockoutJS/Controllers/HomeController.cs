using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.Mvc;

namespace KnockoutJS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Test()
        {
            List<Item> listItem = new List<Item>()
            {
                new Item(){name = "Well-Travelled Kitten",sales = 352,price = 75.95M},
                new Item(){name = "Speedy Coyote",sales = 89,price = 190.00M},
            };
            return Json(listItem, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }

    public class Item
    {
        public string name { get; set; }
        public int sales { get; set; }
        public decimal price { get; set; }
    }
}
