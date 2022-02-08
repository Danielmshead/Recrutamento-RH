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
    public class CandidatoRefTechesController : Controller
    {
        private RHEntities1 db = new RHEntities1();

        // GET: CandidatoRefTeches
        public ActionResult Index()
        {
            return View(db.CandidatoRefTeches.ToList());
        }

        // GET: CandidatoRefTeches/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CandidatoRefTech candidatoRefTech = db.CandidatoRefTeches.Find(id);
            if (candidatoRefTech == null)
            {
                return HttpNotFound();
            }
            return View(candidatoRefTech);
        }

        // GET: CandidatoRefTeches/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CandidatoRefTeches/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CandidatoRefTechID,CandidatoRefTechName")] CandidatoRefTech candidatoRefTech)
        {
            if (ModelState.IsValid)
            {
                db.CandidatoRefTeches.Add(candidatoRefTech);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(candidatoRefTech);
        }

        // GET: CandidatoRefTeches/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CandidatoRefTech candidatoRefTech = db.CandidatoRefTeches.Find(id);
            if (candidatoRefTech == null)
            {
                return HttpNotFound();
            }
            return View(candidatoRefTech);
        }

        // POST: CandidatoRefTeches/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CandidatoRefTechID,CandidatoRefTechName")] CandidatoRefTech candidatoRefTech)
        {
            if (ModelState.IsValid)
            {
                db.Entry(candidatoRefTech).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(candidatoRefTech);
        }

        // GET: CandidatoRefTeches/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CandidatoRefTech candidatoRefTech = db.CandidatoRefTeches.Find(id);
            if (candidatoRefTech == null)
            {
                return HttpNotFound();
            }
            return View(candidatoRefTech);
        }

        // POST: CandidatoRefTeches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CandidatoRefTech candidatoRefTech = db.CandidatoRefTeches.Find(id);
            db.CandidatoRefTeches.Remove(candidatoRefTech);
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
