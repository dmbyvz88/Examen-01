using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Examen_01.Models;

namespace Examen_01.Controllers
{
    public class LaboresController : Controller
    {
        private LaboresContext db = new LaboresContext();

        // GET: Labores
        public ActionResult Index()
        {
            return View(db.Labors.ToList());
        }

        // GET: Labores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Labor labor = db.Labors.Find(id);
            if (labor == null)
            {
                return HttpNotFound();
            }
            return View(labor);
        }

        // GET: Labores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Labores/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idLabor,nombre,precio")] Labor labor)
        {
            if (ModelState.IsValid)
            {
                db.Labors.Add(labor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(labor);
        }

        // GET: Labores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Labor labor = db.Labors.Find(id);
            if (labor == null)
            {
                return HttpNotFound();
            }
            return View(labor);
        }

        // POST: Labores/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idLabor,nombre,precio")] Labor labor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(labor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(labor);
        }

        // GET: Labores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Labor labor = db.Labors.Find(id);
            if (labor == null)
            {
                return HttpNotFound();
            }
            return View(labor);
        }

        // POST: Labores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Labor labor = db.Labors.Find(id);
            db.Labors.Remove(labor);
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
