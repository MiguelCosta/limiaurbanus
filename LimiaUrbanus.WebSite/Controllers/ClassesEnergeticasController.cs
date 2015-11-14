using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LimiaUrbanus.WebSite.Models;

namespace LimiaUrbanus.WebSite.Controllers
{
    public class ClassesEnergeticasController : Controller
    {
        private LimiaUrbanusDbContext db = new LimiaUrbanusDbContext();

        // GET: ClassesEnergeticas
        public ActionResult Index()
        {
            return View(db.ClassesEnergeticas.ToList());
        }

        // GET: ClassesEnergeticas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClasseEnergetica classeEnergetica = db.ClassesEnergeticas.Find(id);
            if (classeEnergetica == null)
            {
                return HttpNotFound();
            }
            return View(classeEnergetica);
        }

        // GET: ClassesEnergeticas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClassesEnergeticas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ClasseEnergeticaId,Nome,Ordem")] ClasseEnergetica classeEnergetica)
        {
            if (ModelState.IsValid)
            {
                db.ClassesEnergeticas.Add(classeEnergetica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(classeEnergetica);
        }

        // GET: ClassesEnergeticas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClasseEnergetica classeEnergetica = db.ClassesEnergeticas.Find(id);
            if (classeEnergetica == null)
            {
                return HttpNotFound();
            }
            return View(classeEnergetica);
        }

        // POST: ClassesEnergeticas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ClasseEnergeticaId,Nome,Ordem")] ClasseEnergetica classeEnergetica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(classeEnergetica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(classeEnergetica);
        }

        // GET: ClassesEnergeticas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClasseEnergetica classeEnergetica = db.ClassesEnergeticas.Find(id);
            if (classeEnergetica == null)
            {
                return HttpNotFound();
            }
            return View(classeEnergetica);
        }

        // POST: ClassesEnergeticas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ClasseEnergetica classeEnergetica = db.ClassesEnergeticas.Find(id);
            db.ClassesEnergeticas.Remove(classeEnergetica);
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
