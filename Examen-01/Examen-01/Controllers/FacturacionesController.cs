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
    public class FacturacionesController : Controller
    {
        private FacturacionesContext db = new FacturacionesContext();

        // GET: Facturaciones
        public ActionResult Index()
        {
            var facturacions = db.Facturacions.Include(f => f.registros);
            return View(facturacions.ToList());
        }

        // GET: Facturaciones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Facturacion facturacion = db.Facturacions.Find(id);
            if (facturacion == null)
            {
                return HttpNotFound();
            }
            return View(facturacion);
        }

        // GET: Facturaciones/Create
        public ActionResult Create()
        {
            ViewBag.idRegistro = new SelectList(db.Registroes, "idRegistro", "observaciones");
            return View();
        }

        // POST: Facturaciones/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idFactura,NFactura,FFactura,idRegistro,totalCancelar")] Facturacion facturacion)
        {
            if (ModelState.IsValid)
            {
                db.Facturacions.Add(facturacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idRegistro = new SelectList(db.Registroes, "idRegistro", "observaciones", facturacion.idRegistro);
            return View(facturacion);
        }

        // GET: Facturaciones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Facturacion facturacion = db.Facturacions.Find(id);
            if (facturacion == null)
            {
                return HttpNotFound();
            }
            ViewBag.idRegistro = new SelectList(db.Registroes, "idRegistro", "observaciones", facturacion.idRegistro);
            return View(facturacion);
        }

        // POST: Facturaciones/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idFactura,NFactura,FFactura,idRegistro,totalCancelar")] Facturacion facturacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(facturacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idRegistro = new SelectList(db.Registroes, "idRegistro", "observaciones", facturacion.idRegistro);
            return View(facturacion);
        }

        // GET: Facturaciones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Facturacion facturacion = db.Facturacions.Find(id);
            if (facturacion == null)
            {
                return HttpNotFound();
            }
            return View(facturacion);
        }

        // POST: Facturaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Facturacion facturacion = db.Facturacions.Find(id);
            db.Facturacions.Remove(facturacion);
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
