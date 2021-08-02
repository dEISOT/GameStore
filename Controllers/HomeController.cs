using GameAchieves.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameAchieves.Controllers
{
    public class HomeController : Controller
    {
        GameContext db = new GameContext();
        public ActionResult Index()
        {
            var games = db.Games;
            ViewBag.Games = games;
            return View();
        }
        [HttpGet]
        public ActionResult Buy(int Id)
        {
            ViewBag.GameId = Id;
            return View();
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            db.Purchases.Add(purchase);
            db.SaveChanges();
            return "Thank you," + purchase.Person + " for your purchase";
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}