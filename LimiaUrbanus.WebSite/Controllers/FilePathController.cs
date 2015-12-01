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
    public class FilePathController : Controller
    {
        private LimiaUrbanusDbContext db = new LimiaUrbanusDbContext();

        // GET: FilePath
        public ActionResult Index()
        {
            var filePaths = db.FilePath.Include(f => f.Imovel);
            return View(filePaths.ToList());
        }

        // GET: FilePath/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FilePath filePath = db.FilePath.Find(id);
            if (filePath == null)
            {
                return HttpNotFound();
            }
            return View(filePath);
        }

        // GET: FilePath/Create
        public ActionResult Create()
        {
            ViewBag.ImovelId = new SelectList(db.Imoveis, "ImovelId", "Nome");
            return View();
        }

        // POST: FilePath/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FilePathId,FileName,FileTye,ImovelId,IsPrincipal,IsCapa")] FilePath filePath)
        {
            if (ModelState.IsValid)
            {
                db.FilePath.Add(filePath);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ImovelId = new SelectList(db.Imoveis, "ImovelId", "Nome", filePath.ImovelId);
            return View(filePath);
        }

        // GET: FilePath/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FilePath filePath = db.FilePath.Find(id);
            if (filePath == null)
            {
                return HttpNotFound();
            }
            ViewBag.ImovelId = new SelectList(db.Imoveis, "ImovelId", "Nome", filePath.ImovelId);
            return View(filePath);
        }

        // POST: FilePath/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FilePathId,FileName,FileTye,ImovelId,IsPrincipal,IsCapa")] FilePath filePath)
        {
            if (ModelState.IsValid)
            {
                db.Entry(filePath).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ImovelId = new SelectList(db.Imoveis, "ImovelId", "Nome", filePath.ImovelId);
            return View(filePath);
        }

        // GET: FilePath/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FilePath filePath = db.FilePath.Find(id);
            if (filePath == null)
            {
                return HttpNotFound();
            }
            return View(filePath);
        }

        // POST: FilePath/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FilePath filePath = db.FilePath.Find(id);
            db.FilePath.Remove(filePath);
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
