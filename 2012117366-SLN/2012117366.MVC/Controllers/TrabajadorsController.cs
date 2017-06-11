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
using _2012117366_ENT.IRepositories;

namespace _2012117366.MVC.Controllers
{
    public class TrabajadorsController : Controller
    {
        private readonly IUnityOfWork _UnityOfWork;

        public TrabajadorsController()
        {


        }
        public TrabajadorsController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }





        // GET: Trabajadors
        public ActionResult Index()
        {
            return View(_UnityOfWork.AdministradorEquipo.GetAll());
        }

        // GET: Trabajadors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // Cliente cliente = db.Clientes.Find(id);
            Trabajador trabajador = _UnityOfWork.Trabajador.Get(id);


            if (trabajador == null)
            {
                return HttpNotFound();
            }
            return View(trabajador);
        }

        // GET: Trabajadors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Trabajadors/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TrabajadorID,TipoTrabajador,EvaluacionID")] Trabajador trabajador)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(cliente).State = EntityState.Modified;
                _UnityOfWork.StateModified(trabajador);

                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trabajador);
        }

        // GET: Trabajadors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //autor YOHAN TAPIA BARRRIGA :D NO COPIAR MI GIT HUBBBBBB!!!!!
            Trabajador trabajador = _UnityOfWork.Trabajador.Get(id);
            if (trabajador == null)
            {
                return HttpNotFound();
            }
            return View(trabajador);
        }

        // POST: Trabajadors/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TrabajadorID,TipoTrabajador,EvaluacionID")] Trabajador trabajador)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(cliente).State = EntityState.Modified;
                _UnityOfWork.StateModified(trabajador);

                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trabajador);
        }

        // GET: Trabajadors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trabajador trabajador = _UnityOfWork.Trabajador.Get(id);
            if ( trabajador== null)
            {
                return HttpNotFound();
            }
            return View(trabajador);
        }

        // POST: Trabajadors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Trabajador Trabajador = _UnityOfWork.Trabajador.Get(id);
            // db.Clientes.Remove(cliente);
            _UnityOfWork.Trabajador.Delete(Trabajador);

            //db.SaveChanges();
            _UnityOfWork.SaveChanges();

            return RedirectToAction("Index");
        }

      protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // db.Dispose();
                _UnityOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
