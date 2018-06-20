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
        private AppDbContext db = new AppDbContext();

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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TakeCredit([Bind(Include = "Name, Surname,Patronymic,Email,LoanAmount,NumberPhone")] People person)
        {
            if (ModelState.IsValid)
            {
               // db.People.(person);
                db.SaveChanges();
                return RedirectToAction("Send");
            }

            return View(person);
        }

        public ActionResult Send ()
        {
            return View();
        }
       
    }
}