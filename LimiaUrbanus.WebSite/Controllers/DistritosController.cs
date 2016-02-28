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
    public class DistritosController : Controller
    {
        private LimiaUrbanusDbContext db = new LimiaUrbanusDbContext();

        // GET: Distritos
        public ActionResult Index()
        {
            return View(db.Distritos.ToList());
        }

        // GET: Distritos/Details/5
        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Distrito distrito = db.Distritos.Find(id);
            if(distrito == null)
            {
                return HttpNotFound();
            }
            return View(distrito);
        }

        // GET: Distritos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Distritos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DistritoId,Nome")] Distrito distrito)
        {
            if(ModelState.IsValid)
            {
                db.Distritos.Add(distrito);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(distrito);
        }

        // GET: Distritos/Edit/5
        public ActionResult Edit(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Distrito distrito = db.Distritos.Find(id);
            if(distrito == null)
            {
                return HttpNotFound();
            }
            return View(distrito);
        }

        // POST: Distritos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DistritoId,Nome")] Distrito distrito)
        {
            if(ModelState.IsValid)
            {
                db.Entry(distrito).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(distrito);
        }

        // GET: Distritos/Delete/5
        public ActionResult Delete(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Distrito distrito = db.Distritos.Find(id);
            if(distrito == null)
            {
                return HttpNotFound();
            }
            return View(distrito);
        }

        // POST: Distritos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Distrito distrito = db.Distritos.Find(id);
            db.Distritos.Remove(distrito);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public JsonResult GetDistritos()
        {
            var ob =
                db.Distritos.OrderBy(x => x.Nome).Select(x => new { x.DistritoId, x.Nome }).ToList();
            return Json(ob, JsonRequestBehavior.AllowGet);
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
