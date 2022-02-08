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
    [Authorize]
    public class VagaRefDetalhesController : Controller
    {
        private RHEntities1 db = new RHEntities1();

        // GET: VagaRefDetalhes
        public ActionResult Index()
        {
            return View(db.VagaRefDetalhes.ToList());
        }

        // GET: VagaRefDetalhes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VagaRefDetalhe vagaRefDetalhe = db.VagaRefDetalhes.Find(id);
            if (vagaRefDetalhe == null)
            {
                return HttpNotFound();
            }
            return View(vagaRefDetalhe);
        }

        // GET: VagaRefDetalhes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VagaRefDetalhes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VagaRefDetalheID,VagaRefDetalheName")] VagaRefDetalhe vagaRefDetalhe)
        {
            if (ModelState.IsValid)
            {
                db.VagaRefDetalhes.Add(vagaRefDetalhe);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vagaRefDetalhe);
        }

        // GET: VagaRefDetalhes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VagaRefDetalhe vagaRefDetalhe = db.VagaRefDetalhes.Find(id);
            if (vagaRefDetalhe == null)
            {
                return HttpNotFound();
            }
            return View(vagaRefDetalhe);
        }

        // POST: VagaRefDetalhes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VagaRefDetalheID,VagaRefDetalheName")] VagaRefDetalhe vagaRefDetalhe)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vagaRefDetalhe).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vagaRefDetalhe);
        }

        // GET: VagaRefDetalhes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VagaRefDetalhe vagaRefDetalhe = db.VagaRefDetalhes.Find(id);
            if (vagaRefDetalhe == null)
            {
                return HttpNotFound();
            }
            return View(vagaRefDetalhe);
        }

        // POST: VagaRefDetalhes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VagaRefDetalhe vagaRefDetalhe = db.VagaRefDetalhes.Find(id);
            db.VagaRefDetalhes.Remove(vagaRefDetalhe);
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
