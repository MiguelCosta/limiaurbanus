using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using LimiaUrbanus.WebSite.Models;

namespace LimiaUrbanus.WebSite.Controllers
{
    public class TipologiasController : Controller
    {
        private LimiaUrbanusDbContext db = new LimiaUrbanusDbContext();

        // GET: Tipologias
        public ActionResult Index()
        {
            return View(db.Tipologias.ToList());
        }

        // GET: Tipologias/Details/5
        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tipologia tipologia = db.Tipologias.Find(id);
            if(tipologia == null)
            {
                return HttpNotFound();
            }
            return View(tipologia);
        }

        // GET: Tipologias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tipologias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TipologiaId,Nome,Ordem")] Tipologia tipologia)
        {
            if(ModelState.IsValid)
            {
                db.Tipologias.Add(tipologia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipologia);
        }

        // GET: Tipologias/Edit/5
        public ActionResult Edit(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tipologia tipologia = db.Tipologias.Find(id);
            if(tipologia == null)
            {
                return HttpNotFound();
            }
            return View(tipologia);
        }

        // POST: Tipologias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TipologiaId,Nome,Ordem")] Tipologia tipologia)
        {
            if(ModelState.IsValid)
            {
                db.Entry(tipologia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipologia);
        }

        // GET: Tipologias/Delete/5
        public ActionResult Delete(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tipologia tipologia = db.Tipologias.Find(id);
            if(tipologia == null)
            {
                return HttpNotFound();
            }
            return View(tipologia);
        }

        // POST: Tipologias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tipologia tipologia = db.Tipologias.Find(id);
            db.Tipologias.Remove(tipologia);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public JsonResult GetTipologias()
        {
            var ob =
                db.Tipologias.OrderBy(x => x.Ordem).Select(x => new { x.TipologiaId, x.Nome }).ToList();
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
