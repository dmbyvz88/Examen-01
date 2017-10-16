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
    public class MecanicosController : Controller
    {
        private MecanicosContext db = new MecanicosContext();

        // GET: Mecanicos
        public ActionResult Index()
        {
            return View(db.Mecanicoes.ToList());
        }

        // GET: Mecanicos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mecanico mecanico = db.Mecanicoes.Find(id);
            if (mecanico == null)
            {
                return HttpNotFound();
            }
            return View(mecanico);
        }

        // GET: Mecanicos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mecanicos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idMecanico,nombre")] Mecanico mecanico)
        {
            if (ModelState.IsValid)
            {
                db.Mecanicoes.Add(mecanico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mecanico);
        }

        // GET: Mecanicos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mecanico mecanico = db.Mecanicoes.Find(id);
            if (mecanico == null)
            {
                return HttpNotFound();
            }
            return View(mecanico);
        }

        // POST: Mecanicos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idMecanico,nombre")] Mecanico mecanico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mecanico).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mecanico);
        }

        // GET: Mecanicos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mecanico mecanico = db.Mecanicoes.Find(id);
            if (mecanico == null)
            {
                return HttpNotFound();
            }
            return View(mecanico);
        }

        // POST: Mecanicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mecanico mecanico = db.Mecanicoes.Find(id);
            db.Mecanicoes.Remove(mecanico);
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
