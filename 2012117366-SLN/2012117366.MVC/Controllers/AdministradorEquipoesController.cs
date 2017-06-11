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
    public class AdministradorEquipoesController : Controller
    {
        private readonly IUnityOfWork _UnityOfWork;


        public AdministradorEquipoesController()
        {


        }
        public AdministradorEquipoesController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }
        // GET: AdministradorEquipoes
        public ActionResult Index()
        {
            return View(_UnityOfWork.AdministradorEquipo.GetAll());
        }

        // GET: AdministradorEquipoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // Cliente cliente = db.Clientes.Find(id);
            AdministradorEquipo administradorEquipo = _UnityOfWork.AdministradorEquipo.Get(id);


            if (administradorEquipo == null)
            {
                return HttpNotFound();
            }
            return View(administradorEquipo);
        }

        // GET: AdministradorEquipoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdministradorEquipoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AdministradorEquipoID")] AdministradorEquipo administradorEquipo)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(cliente).State = EntityState.Modified;
                _UnityOfWork.StateModified(administradorEquipo);

                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(administradorEquipo);
        }

        // GET: AdministradorEquipoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //autor YOHAN TAPIA BARRRIGA :D NO COPIAR MI GIT HUBBBBBB!!!!!
            AdministradorEquipo administradorEquipo = _UnityOfWork.AdministradorEquipo.Get(id);
            if (administradorEquipo == null)
            {
                return HttpNotFound();
            }
            return View(administradorEquipo);
        }
        // POST: AdministradorEquipoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AdministradorEquipoID")] AdministradorEquipo administradorEquipo)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(cliente).State = EntityState.Modified;
                _UnityOfWork.StateModified(administradorEquipo);

                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(administradorEquipo);
        }

        // GET: AdministradorEquipoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdministradorEquipo administradorEquipo = _UnityOfWork.AdministradorEquipo.Get(id);
            if (administradorEquipo == null)
            {
                return HttpNotFound();
            }
            return View(administradorEquipo);
        }

        // POST: AdministradorEquipoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AdministradorEquipo administradorEquipo = _UnityOfWork.AdministradorEquipo.Get(id);
            // db.Clientes.Remove(cliente);
            _UnityOfWork.AdministradorEquipo.Delete(administradorEquipo);

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
