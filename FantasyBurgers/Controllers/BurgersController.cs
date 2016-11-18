using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FantasyBurgers.Models;

namespace FantasyBurgers.Controllers
{
    public class BurgersController : Controller
    {
        private FantasyBurgerResturantContext db = new FantasyBurgerResturantContext();

        // GET: Burgers
        public ActionResult Index()
        {
            return View(db.Burgers.ToList());
        }

        // GET: Burgers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Burger burger = db.Burgers.Find(id);
            if (burger == null)
            {
                return HttpNotFound();
            }
            return View(burger);
        }
    }
}
