using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PRUEBA_TECNICA_SEIDOR_ACGR_Proyecto.Models;

namespace PRUEBA_TECNICA_SEIDOR_ACGR_Proyecto.Controllers
{
    public class VENDEDORsController : Controller
    {
        private PRUEBA_TECNICA_SEIDOR_ACGREntities db = new PRUEBA_TECNICA_SEIDOR_ACGREntities();

        // GET: VENDEDORs
        public ActionResult Index()
        {
            return View(db.VENDEDOR.ToList());
        }

        // GET: VENDEDORs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VENDEDOR vENDEDOR = db.VENDEDOR.Find(id);
            if (vENDEDOR == null)
            {
                return HttpNotFound();
            }
            return View(vENDEDOR);
        }

        // GET: VENDEDORs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VENDEDORs/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CODIGO,NOMBRE,APELLIDO,NUMERO_IDENTIFICACION,CODIGO_CIUDAD")] VENDEDOR vENDEDOR)
        {
            if (ModelState.IsValid)
            {
                db.VENDEDOR.Add(vENDEDOR);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vENDEDOR);
        }

        // GET: VENDEDORs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VENDEDOR vENDEDOR = db.VENDEDOR.Find(id);
            if (vENDEDOR == null)
            {
                return HttpNotFound();
            }
            return View(vENDEDOR);
        }

        // POST: VENDEDORs/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CODIGO,NOMBRE,APELLIDO,NUMERO_IDENTIFICACION,CODIGO_CIUDAD")] VENDEDOR vENDEDOR)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vENDEDOR).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vENDEDOR);
        }

        // GET: VENDEDORs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VENDEDOR vENDEDOR = db.VENDEDOR.Find(id);
            if (vENDEDOR == null)
            {
                return HttpNotFound();
            }
            return View(vENDEDOR);
        }

        // POST: VENDEDORs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VENDEDOR vENDEDOR = db.VENDEDOR.Find(id);
            db.VENDEDOR.Remove(vENDEDOR);
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
