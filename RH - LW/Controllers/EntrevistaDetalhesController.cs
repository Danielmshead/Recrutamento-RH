using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RH___LW.Models;

namespace RH___LW.Controllers
{
    public class EntrevistaDetalhesController : Controller
    {
        private RHEntities4 db = new RHEntities4();

        // GET: EntrevistaDetalhes
        public ActionResult Index()
        {
            return View(db.EntrevistaDetalhes.ToList());
        }

        // GET: EntrevistaDetalhes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntrevistaDetalhe entrevistaDetalhe = db.EntrevistaDetalhes.Find(id);
            if (entrevistaDetalhe == null)
            {
                return HttpNotFound();
            }
            return View(entrevistaDetalhe);
        }

        // GET: EntrevistaDetalhes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EntrevistaDetalhes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NomeID,Descrevaumpoucosobrevocê,Digiteoqueseusexchefesdiriamsobrevocê,Digiteoquevocêsabesobreanossaempresaenossaculturaorganizacional,Digiteoporquevocêdecidiusecandidataraestavaga,Digiteoqueseuscolegasdetrabalhodiriamsobrevocê,Digitequaissãoos_seus_pontos_fortesefracos,DigitesobresuaexperiênciacomoDev,Digiteoporquevocêquersairousaiudaúltimaempresa")] EntrevistaDetalhe entrevistaDetalhe)
        {
            if (ModelState.IsValid)
            {
                db.EntrevistaDetalhes.Add(entrevistaDetalhe);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(entrevistaDetalhe);
        }

        // GET: EntrevistaDetalhes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntrevistaDetalhe entrevistaDetalhe = db.EntrevistaDetalhes.Find(id);
            if (entrevistaDetalhe == null)
            {
                return HttpNotFound();
            }
            return View(entrevistaDetalhe);
        }

        // POST: EntrevistaDetalhes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NomeID,Descrevaumpoucosobrevocê,Digiteoqueseusexchefesdiriamsobrevocê,Digiteoquevocêsabesobreanossaempresaenossaculturaorganizacional,Digiteoporquevocêdecidiusecandidataraestavaga,Digiteoqueseuscolegasdetrabalhodiriamsobrevocê,Digitequaissãoos_seus_pontos_fortesefracos,DigitesobresuaexperiênciacomoDev,Digiteoporquevocêquersairousaiudaúltimaempresa")] EntrevistaDetalhe entrevistaDetalhe)
        {
            if (ModelState.IsValid)
            {
                db.Entry(entrevistaDetalhe).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(entrevistaDetalhe);
        }

        // GET: EntrevistaDetalhes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntrevistaDetalhe entrevistaDetalhe = db.EntrevistaDetalhes.Find(id);
            if (entrevistaDetalhe == null)
            {
                return HttpNotFound();
            }
            return View(entrevistaDetalhe);
        }

        // POST: EntrevistaDetalhes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EntrevistaDetalhe entrevistaDetalhe = db.EntrevistaDetalhes.Find(id);
            db.EntrevistaDetalhes.Remove(entrevistaDetalhe);
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
