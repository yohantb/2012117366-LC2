using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _2012117366_ENT;
using _2012117366_PER;

namespace _2012117366.MVC.Controllers
{
    public class VentasController : Controller
    {
        private TapiaDbContext db = new TapiaDbContext();

        // GET: Ventas
        public ActionResult Index()
        {
            var venta = db.Venta.Include(v => v.CentroAtencion).Include(v => v.Cliente);
            return View(venta.ToList());
        }

        // GET: Ventas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Venta venta = db.Venta.Find(id);
            if (venta == null)
            {
                return HttpNotFound();
            }
            return View(venta);
        }

        // GET: Ventas/Create
        public ActionResult Create()
        {
            ViewBag.CentroAtencionID = new SelectList(db.CentroAtencion, "CentroAtencionID", "CentroAtencionID");
            ViewBag.ClienteId = new SelectList(db.Cliente, "ClienteID", "ClienteID");
            return View();
        }

        // POST: Ventas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VentaID,ClienteId,TipoPago,ContratoId,EvaluacionId,LineaTelefonicaId,CentroAtencionID")] Venta venta)
        {
            if (ModelState.IsValid)
            {
                db.Venta.Add(venta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CentroAtencionID = new SelectList(db.CentroAtencion, "CentroAtencionID", "CentroAtencionID", venta.CentroAtencionID);
            ViewBag.ClienteId = new SelectList(db.Cliente, "ClienteID", "ClienteID", venta.ClienteId);
            return View(venta);
        }

        // GET: Ventas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Venta venta = db.Venta.Find(id);
            if (venta == null)
            {
                return HttpNotFound();
            }
            ViewBag.CentroAtencionID = new SelectList(db.CentroAtencion, "CentroAtencionID", "CentroAtencionID", venta.CentroAtencionID);
            ViewBag.ClienteId = new SelectList(db.Cliente, "ClienteID", "ClienteID", venta.ClienteId);
            return View(venta);
        }

        // POST: Ventas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VentaID,ClienteId,TipoPago,ContratoId,EvaluacionId,LineaTelefonicaId,CentroAtencionID")] Venta venta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(venta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CentroAtencionID = new SelectList(db.CentroAtencion, "CentroAtencionID", "CentroAtencionID", venta.CentroAtencionID);
            ViewBag.ClienteId = new SelectList(db.Cliente, "ClienteID", "ClienteID", venta.ClienteId);
            return View(venta);
        }

        // GET: Ventas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Venta venta = db.Venta.Find(id);
            if (venta == null)
            {
                return HttpNotFound();
            }
            return View(venta);
        }

        // POST: Ventas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Venta venta = db.Venta.Find(id);
            db.Venta.Remove(venta);
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
