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
    public class RegistrosController : Controller
    {
        private RegistroContext db = new RegistroContext();

        // GET: Registros
        public ActionResult Index()
        {
            var registroes = db.Registroes.Include(r => r.autos).Include(r => r.labores).Include(r => r.mecanicos).Include(r => r.repuestos);
            return View(registroes.ToList());
        }

        // GET: Registros/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Registro registro = db.Registroes.Find(id);
            if (registro == null)
            {
                return HttpNotFound();
            }
            return View(regi    stro);
        }

        // GET: Registros/Create
        public ActionResult Create()
        {
            ViewBag.idAuto = new SelectList(db.Autoes, "idAuto", "marca");
            ViewBag.idLabor = new SelectList(db.Labors, "idLabor", "nombre");
            ViewBag.idMecanico = new SelectList(db.Mecanicoes, "idMecanico", "nombre");
            ViewBag.idRepuesto = new SelectList(db.Repuestos, "idRepuesto", "nombre");
            return View();
        }

        // POST: Registros/Create Guarda los datos ingresados en la base de datos
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idRegistro,fIngreso,idAuto,idLabor,idRepuesto,cantidad,idMecanico,observaciones")] Registro registro)
        {
            if (ModelState.IsValid)
            {
                db.Registroes.Add(registro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idAuto = new SelectList(db.Autoes, "idAuto", "marca", registro.idAuto);
            ViewBag.idLabor = new SelectList(db.Labors, "idLabor", "nombre", registro.idLabor);
            ViewBag.idMecanico = new SelectList(db.Mecanicoes, "idMecanico", "nombre", registro.idMecanico);
            ViewBag.idRepuesto = new SelectList(db.Repuestos, "idRepuesto", "nombre", registro.idRepuesto);
            return View(registro);
        }

        // GET: Registros/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Registro registro = db.Registroes.Find(id);
            if (registro == null)
            {
                return HttpNotFound();
            }
            ViewBag.idAuto = new SelectList(db.Autoes, "idAuto", "marca", registro.idAuto);
            ViewBag.idLabor = new SelectList(db.Labors, "idLabor", "nombre", registro.idLabor);
            ViewBag.idMecanico = new SelectList(db.Mecanicoes, "idMecanico", "nombre", registro.idMecanico);
            ViewBag.idRepuesto = new SelectList(db.Repuestos, "idRepuesto", "nombre", registro.idRepuesto);
            return View(registro);
        }

        // POST: Registros/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idRegistro,fIngreso,idAuto,idLabor,idRepuesto,cantidad,idMecanico,observaciones")] Registro registro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(registro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idAuto = new SelectList(db.Autoes, "idAuto", "marca", registro.idAuto);
            ViewBag.idLabor = new SelectList(db.Labors, "idLabor", "nombre", registro.idLabor);
            ViewBag.idMecanico = new SelectList(db.Mecanicoes, "idMecanico", "nombre", registro.idMecanico);
            ViewBag.idRepuesto = new SelectList(db.Repuestos, "idRepuesto", "nombre", registro.idRepuesto);
            return View(registro);
        }

        // GET: Registros/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Registro registro = db.Registroes.Find(id);
            if (registro == null)
            {
                return HttpNotFound();
            }
            return View(registro);
        }

        // POST: Registros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Registro registro = db.Registroes.Find(id);
            db.Registroes.Remove(registro);
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
