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
    public class ConcelhosController : Controller
    {
        private LimiaUrbanusDbContext db = new LimiaUrbanusDbContext();

        // GET: Concelhos
        public ActionResult Index()
        {
            var concelhoes = db.Concelhos.Include(c => c.Distrito);
            return View(concelhoes.ToList());
        }

        // GET: Concelhos/Details/5
        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Concelho concelho = db.Concelhos.Find(id);
            if(concelho == null)
            {
                return HttpNotFound();
            }
            return View(concelho);
        }

        // GET: Concelhos/Create
        [Authorize]
        public ActionResult Create()
        {
            ViewBag.DistritoId = new SelectList(db.Distritos, "DistritoId", "Nome");
            return View();
        }

        // POST: Concelhos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create([Bind(Include = "ConcelhoId,Nome,DistritoId")] Concelho concelho)
        {
            if(ModelState.IsValid)
            {
                db.Concelhos.Add(concelho);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DistritoId = new SelectList(db.Distritos, "DistritoId", "Nome", concelho.DistritoId);
            return View(concelho);
        }

        // GET: Concelhos/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Concelho concelho = db.Concelhos.Find(id);
            if(concelho == null)
            {
                return HttpNotFound();
            }
            ViewBag.DistritoId = new SelectList(db.Distritos, "DistritoId", "Nome", concelho.DistritoId);
            return View(concelho);
        }

        // POST: Concelhos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit([Bind(Include = "ConcelhoId,Nome,DistritoId")] Concelho concelho)
        {
            if(ModelState.IsValid)
            {
                db.Entry(concelho).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DistritoId = new SelectList(db.Distritos, "DistritoId", "Nome", concelho.DistritoId);
            return View(concelho);
        }

        // GET: Concelhos/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Concelho concelho = db.Concelhos.Find(id);
            if(concelho == null)
            {
                return HttpNotFound();
            }
            return View(concelho);
        }

        // POST: Concelhos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult DeleteConfirmed(int id)
        {
            Concelho concelho = db.Concelhos.Find(id);
            db.Concelhos.Remove(concelho);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public JsonResult GetConcelhos(int? distritoId)
        {
            var r = distritoId.HasValue ? db.Concelhos.Where(x => x.DistritoId == distritoId.Value) : db.Concelhos;

            var result = r.OrderBy(x => x.Nome).Select(x => new { x.ConcelhoId, x.Nome }).ToList();
            return Json(result, JsonRequestBehavior.AllowGet);
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
