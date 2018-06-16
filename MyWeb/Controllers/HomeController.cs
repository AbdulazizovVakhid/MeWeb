using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;


namespace MyWeb.Controllers
{
    public class HomeController : Controller
    {
        //private AppDbContext db = new AppDbContext();

        // People peop = db.People.FerstOrDefault(q => q.Name == Name);

        //db.Name.Add(peo);

        //db.SaveChanges();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Наша контактная страница";

            return View();
        }

        public ActionResult TakeCredit()
        {
            return View();
        }

        public ActionResult Send ()
        {
            return View();
        }
       
    }
}