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
    public class AppetizersController : Controller
    {
        private FantasyBurgerResturantContext db = new FantasyBurgerResturantContext();

        // GET: Appetizers
        public ActionResult Index()
        {
            return View(db.Appetizers.ToList());
        }

        // GET: Appetizers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appetizer appetizer = db.Appetizers.Find(id);
            if (appetizer == null)
            {
                return HttpNotFound();
            }
            return View(appetizer);
        }
    }
}
