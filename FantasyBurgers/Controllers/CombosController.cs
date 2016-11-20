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
    public class CombosController : Controller
    {
        private FantasyBurgersContext db = new FantasyBurgersContext();

        // GET: Combos
        public ActionResult Index()
        {
            return View(db.Combos.ToList());
        }

        //Get: Combos/Admin
        public ActionResult Admin()
        {
            return View(db.Combos.ToList());
        }
        // GET: Combos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Combo combo = db.Combos.Find(id);
            if (combo == null)
            {
                return HttpNotFound();
            }
            return View(combo);
        }

        // GET: Combos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Combos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ComboId,ComboName,ComboShortDescription,ComboLongDescription,ComboPrice,ComboImage")] Combo combo)
        {
            if (ModelState.IsValid)
            {
                db.Combos.Add(combo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(combo);
        }

        // GET: Combos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Combo combo = db.Combos.Find(id);
            if (combo == null)
            {
                return HttpNotFound();
            }
            return View(combo);
        }

        // POST: Combos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ComboId,ComboName,ComboShortDescription,ComboLongDescription,ComboPrice,ComboImage")] Combo combo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(combo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(combo);
        }

        // GET: Combos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Combo combo = db.Combos.Find(id);
            if (combo == null)
            {
                return HttpNotFound();
            }
            return View(combo);
        }

        // POST: Combos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Combo combo = db.Combos.Find(id);
            db.Combos.Remove(combo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
