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
    public class FreguesiasController : Controller
    {
        private LimiaUrbanusDbContext db = new LimiaUrbanusDbContext();

        // GET: Freguesias
        public ActionResult Index()
        {
            var freguesias = db.Freguesias.Include(f => f.Concelho);
            return View(freguesias.ToList());
        }

        // GET: Freguesias/Details/5
        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Freguesia freguesia = db.Freguesias.Find(id);
            if(freguesia == null)
            {
                return HttpNotFound();
            }
            return View(freguesia);
        }

        // GET: Freguesias/Create
        public ActionResult Create()
        {
            ViewBag.ConcelhoId = new SelectList(db.Concelhos, "ConcelhoId", "Nome");
            return View();
        }

        // POST: Freguesias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FreguesiaId,Nome,ConcelhoId")] Freguesia freguesia)
        {
            if(ModelState.IsValid)
            {
                db.Freguesias.Add(freguesia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ConcelhoId = new SelectList(db.Concelhos, "ConcelhoId", "Nome", freguesia.ConcelhoId);
            return View(freguesia);
        }

        // GET: Freguesias/Edit/5
        public ActionResult Edit(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Freguesia freguesia = db.Freguesias.Find(id);
            if(freguesia == null)
            {
                return HttpNotFound();
            }
            ViewBag.ConcelhoId = new SelectList(db.Concelhos, "ConcelhoId", "Nome", freguesia.ConcelhoId);
            return View(freguesia);
        }

        // POST: Freguesias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FreguesiaId,Nome,ConcelhoId")] Freguesia freguesia)
        {
            if(ModelState.IsValid)
            {
                db.Entry(freguesia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ConcelhoId = new SelectList(db.Concelhos, "ConcelhoId", "Nome", freguesia.ConcelhoId);
            return View(freguesia);
        }

        // GET: Freguesias/Delete/5
        public ActionResult Delete(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Freguesia freguesia = db.Freguesias.Find(id);
            if(freguesia == null)
            {
                return HttpNotFound();
            }
            return View(freguesia);
        }

        // POST: Freguesias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Freguesia freguesia = db.Freguesias.Find(id);
            db.Freguesias.Remove(freguesia);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
