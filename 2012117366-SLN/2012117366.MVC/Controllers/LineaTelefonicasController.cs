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
    public class LineaTelefonicasController : Controller
    {
        private readonly IUnityOfWork _UnityOfWork;

        public LineaTelefonicasController()
        {


        }
        public LineaTelefonicasController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }











        // GET: LineaTelefonicas
        public ActionResult Index()
        {
            return View(_UnityOfWork.LineaTelefonica.GetAll());
        }

        // GET: LineaTelefonicas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // Cliente cliente = db.Clientes.Find(id);
            LineaTelefonica lineaTelefonica = _UnityOfWork.LineaTelefonica.Get(id);


            if (lineaTelefonica == null)
            {
                return HttpNotFound();
            }
            return View(lineaTelefonica);
        }
        // GET: LineaTelefonicas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LineaTelefonicas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LineaTelefonicaID,TipoLinea,AdministradorLineaID,VentaID,EvaluacionID")] LineaTelefonica lineaTelefonica)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(cliente).State = EntityState.Modified;
                _UnityOfWork.StateModified(lineaTelefonica);

                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lineaTelefonica);
        }

        // GET: LineaTelefonicas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //autor YOHAN TAPIA BARRRIGA :D NO COPIAR MI GIT HUBBBBBB!!!!!
            LineaTelefonica lineaTelefonica = _UnityOfWork.LineaTelefonica.Get(id);
            if (lineaTelefonica == null)
            {
                return HttpNotFound();
            }
            return View(lineaTelefonica);
        }

        // POST: LineaTelefonicas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LineaTelefonicaID,TipoLinea,AdministradorLineaID,VentaID,EvaluacionID")] LineaTelefonica lineaTelefonica)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(cliente).State = EntityState.Modified;
                _UnityOfWork.StateModified(lineaTelefonica);

                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lineaTelefonica);
        }

        // GET: LineaTelefonicas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LineaTelefonica lineaTelefonica = _UnityOfWork.LineaTelefonica.Get(id);
            if (lineaTelefonica == null)
            {
                return HttpNotFound();
            }
            return View(lineaTelefonica);
        }

        // POST: LineaTelefonicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LineaTelefonica lineaTelefonica = _UnityOfWork.LineaTelefonica.Get(id);
            // db.Clientes.Remove(cliente);
            _UnityOfWork.LineaTelefonica.Delete(lineaTelefonica);

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
