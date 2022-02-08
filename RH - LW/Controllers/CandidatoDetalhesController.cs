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
    public class CandidatoDetalhesController : Controller
    {
        private RHEntities1 db = new RHEntities1();

        // GET: CandidatoDetalhes
        public ActionResult Index()
        {
            var candidatoDetalhes = db.CandidatoDetalhes.Include(c => c.CandidatoRefTech);
            return View(candidatoDetalhes.ToList());
        }

        // GET: CandidatoDetalhes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CandidatoDetalhe candidatoDetalhe = db.CandidatoDetalhes.Find(id);
            if (candidatoDetalhe == null)
            {
                return HttpNotFound();
            }
            return View(candidatoDetalhe);
        }

        // GET: CandidatoDetalhes/Create
        public ActionResult Create()
        {
            ViewBag.CandidatoTechID = new SelectList(db.CandidatoRefTeches, "CandidatoRefTechID", "CandidatoRefTechName");
            return View();
        }

        // POST: CandidatoDetalhes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CandidatoID,CandidatoNome,CandidatoIdade,CandidatoEmail,CandidatoEndereco,CandidatoTechID")] CandidatoDetalhe candidatoDetalhe)
        {
            if (ModelState.IsValid)
            {
                db.CandidatoDetalhes.Add(candidatoDetalhe);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CandidatoTechID = new SelectList(db.CandidatoRefTeches, "CandidatoRefTechID", "CandidatoRefTechName", candidatoDetalhe.CandidatoTechID);
            return View(candidatoDetalhe);
        }

        // GET: CandidatoDetalhes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CandidatoDetalhe candidatoDetalhe = db.CandidatoDetalhes.Find(id);
            if (candidatoDetalhe == null)
            {
                return HttpNotFound();
            }
            ViewBag.CandidatoTechID = new SelectList(db.CandidatoRefTeches, "CandidatoRefTechID", "CandidatoRefTechName", candidatoDetalhe.CandidatoTechID);
            return View(candidatoDetalhe);
        }

        // POST: CandidatoDetalhes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CandidatoID,CandidatoNome,CandidatoIdade,CandidatoEmail,CandidatoEndereco,CandidatoTechID")] CandidatoDetalhe candidatoDetalhe)
        {
            if (ModelState.IsValid)
            {
                db.Entry(candidatoDetalhe).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CandidatoTechID = new SelectList(db.CandidatoRefTeches, "CandidatoRefTechID", "CandidatoRefTechName", candidatoDetalhe.CandidatoTechID);
            return View(candidatoDetalhe);
        }

        // GET: CandidatoDetalhes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CandidatoDetalhe candidatoDetalhe = db.CandidatoDetalhes.Find(id);
            if (candidatoDetalhe == null)
            {
                return HttpNotFound();
            }
            return View(candidatoDetalhe);
        }

        // POST: CandidatoDetalhes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CandidatoDetalhe candidatoDetalhe = db.CandidatoDetalhes.Find(id);
            db.CandidatoDetalhes.Remove(candidatoDetalhe);
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
