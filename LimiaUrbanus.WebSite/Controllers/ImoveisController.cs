using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LimiaUrbanus.WebSite.Models;
using LimiaUrbanus.WebSite.ViewModels;

namespace LimiaUrbanus.WebSite.Controllers
{
    public class ImoveisController : Controller
    {
        private LimiaUrbanusDbContext db = new LimiaUrbanusDbContext();

        // GET: Imoveis
        public ActionResult Index()
        {
            var imovels = db.Imoveis.Include(i => i.ClasseEnergetica).Include(i => i.Estado).Include(i => i.Freguesia).Include(i => i.Objetivo).Include(i => i.Tipo).Include(i => i.Tipologia);
            return View(imovels.ToList());
        }

        // GET: Imoveis/Details/5
        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Imovel imovel = db.Imoveis.Find(id);
            if(imovel == null)
            {
                return HttpNotFound();
            }
            return View(imovel);
        }

        // GET: Imoveis/Create
        public ActionResult Create()
        {
            ViewBag.ClasseEnergeticaId = new SelectList(db.ClassesEnergeticas, "ClasseEnergeticaId", "Nome");
            ViewBag.EstadoId = new SelectList(db.Estados, "EstadoId", "Nome");
            ViewBag.FreguesiaId = new SelectList(db.Freguesias, "FreguesiaId", "Nome");
            ViewBag.ObjetivoId = new SelectList(db.Objetivos, "ObjetivoId", "Nome");
            ViewBag.TipoId = new SelectList(db.Tipos, "TipoId", "Nome");
            ViewBag.TipologiaId = new SelectList(db.Tipologias, "TipologiaId", "Nome");
            return View();
        }

        // POST: Imoveis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ImovelId,Nome,Referencia,Descricao,TipoId,EstadoId,FreguesiaId,Morada,CoordenadasGps,ObjetivoId,ClasseEnergeticaId,Area,Wc,TipologiaId,Preco,ContactoResponsavel,IsDestaque,IsPesquisa")] Imovel imovel)
        {
            if(ModelState.IsValid)
            {
                db.Imoveis.Add(imovel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ClasseEnergeticaId = new SelectList(db.ClassesEnergeticas, "ClasseEnergeticaId", "Nome", imovel.ClasseEnergeticaId);
            ViewBag.EstadoId = new SelectList(db.Estados, "EstadoId", "Nome", imovel.EstadoId);
            ViewBag.FreguesiaId = new SelectList(db.Freguesias, "FreguesiaId", "Nome", imovel.FreguesiaId);
            ViewBag.ObjetivoId = new SelectList(db.Objetivos, "ObjetivoId", "Nome", imovel.ObjetivoId);
            ViewBag.TipoId = new SelectList(db.Tipos, "TipoId", "Nome", imovel.TipoId);
            ViewBag.TipologiaId = new SelectList(db.Tipologias, "TipologiaId", "Nome", imovel.TipologiaId);
            return View(imovel);
        }

        // GET: Imoveis/Edit/5
        public ActionResult Edit(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Imovel imovel = db.Imoveis.Find(id);
            if(imovel == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClasseEnergeticaId = new SelectList(db.ClassesEnergeticas, "ClasseEnergeticaId", "Nome", imovel.ClasseEnergeticaId);
            ViewBag.EstadoId = new SelectList(db.Estados, "EstadoId", "Nome", imovel.EstadoId);
            ViewBag.FreguesiaId = new SelectList(db.Freguesias, "FreguesiaId", "Nome", imovel.FreguesiaId);
            ViewBag.ObjetivoId = new SelectList(db.Objetivos, "ObjetivoId", "Nome", imovel.ObjetivoId);
            ViewBag.TipoId = new SelectList(db.Tipos, "TipoId", "Nome", imovel.TipoId);
            ViewBag.TipologiaId = new SelectList(db.Tipologias, "TipologiaId", "Nome", imovel.TipologiaId);
            return View(imovel);
        }

        // POST: Imoveis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ImovelId,Nome,Referencia,Descricao,TipoId,EstadoId,FreguesiaId,Morada,CoordenadasGps,ObjetivoId,ClasseEnergeticaId,Area,Wc,TipologiaId,Preco,ContactoResponsavel,IsDestaque,IsPesquisa")] Imovel imovel)
        {
            if(ModelState.IsValid)
            {
                db.Entry(imovel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ClasseEnergeticaId = new SelectList(db.ClassesEnergeticas, "ClasseEnergeticaId", "Nome", imovel.ClasseEnergeticaId);
            ViewBag.EstadoId = new SelectList(db.Estados, "EstadoId", "Nome", imovel.EstadoId);
            ViewBag.FreguesiaId = new SelectList(db.Freguesias, "FreguesiaId", "Nome", imovel.FreguesiaId);
            ViewBag.ObjetivoId = new SelectList(db.Objetivos, "ObjetivoId", "Nome", imovel.ObjetivoId);
            ViewBag.TipoId = new SelectList(db.Tipos, "TipoId", "Nome", imovel.TipoId);
            ViewBag.TipologiaId = new SelectList(db.Tipologias, "TipologiaId", "Nome", imovel.TipologiaId);
            return View(imovel);
        }

        // GET: Imoveis/Delete/5
        public ActionResult Delete(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Imovel imovel = db.Imoveis.Find(id);
            if(imovel == null)
            {
                return HttpNotFound();
            }
            return View(imovel);
        }

        // POST: Imoveis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Imovel imovel = db.Imoveis.Find(id);
            db.Imoveis.Remove(imovel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Search(ImovelSearch filter)
        {
            var result = new ImoveSearchResult
            {
                Filter = filter ?? new ImovelSearch()
            };

            result.Results = result.Filter.Query(db).ToList();

            return View(result);
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
