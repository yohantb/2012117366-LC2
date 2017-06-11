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
    public class ContratoesController : Controller
    {
        private readonly IUnityOfWork _UnityOfWork;

        public ContratoesController()
        {


        }
        public ContratoesController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }



        // GET: Contratoes
        public ActionResult Index()
        {
            //var contrato = db.Contrato.Include(c => c.Venta);
            return View(_UnityOfWork.Contrato.GetAll());
        }

        // GET: Contratoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // Cliente cliente = db.Clientes.Find(id);
            Contrato contrato = _UnityOfWork.Contrato.Get(id);


            if (contrato == null)
            {
                return HttpNotFound();
            }
            return View(contrato);
        }

        // GET: Contratoes/Create
        public ActionResult Create()
        {
           // ViewBag.ContratoID = new SelectList(db.Venta, "VentaID", "VentaID");
            return View();
        }

        // POST: Contratoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ContratoID,VentaID")] Contrato contrato)
        {
            if (ModelState.IsValid)
            {//AUTORRRRRRRRR _____________ YOHAN ________ TAPIA_________
                _UnityOfWork.StateModified(contrato);

                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contrato);
        }

        // GET: Contratoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //autor YOHAN TAPIA BARRRIGA :D NO COPIAR MI GIT HUBBBBBB!!!!!
            Contrato contrato = _UnityOfWork.Contrato.Get(id);
            if (contrato == null)
            {
                return HttpNotFound();
            }
            return View(contrato);
        }

        // POST: Contratoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ContratoID,VentaID")] Contrato contrato)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(cliente).State = EntityState.Modified;
                _UnityOfWork.StateModified(contrato);

                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contrato);
        }

        // GET: Contratoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contrato contrato = _UnityOfWork.Contrato.Get(id);
            if (contrato == null)
            {
                return HttpNotFound();
            }
            return View(contrato);
        }

        // POST: Contratoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contrato contrato = _UnityOfWork.Contrato.Get(id);
            // db.Clientes.Remove(cliente);
            _UnityOfWork.Contrato.Delete(contrato);

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
