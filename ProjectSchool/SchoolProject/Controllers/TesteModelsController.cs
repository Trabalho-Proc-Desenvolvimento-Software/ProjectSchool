using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SchoolProject.Models;

namespace SchoolProject.Controllers
{
    public class TesteModelsController : Controller
    {
        private DBContext db = new DBContext();

        // GET: TesteModels
        public ActionResult Index()
        {
            return View(db.TesteModels.ToList());
        }

        // GET: TesteModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TesteModel testeModel = db.TesteModels.Find(id);
            if (testeModel == null)
            {
                return HttpNotFound();
            }
            return View(testeModel);
        }

        // GET: TesteModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TesteModels/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cod_teste,texto")] TesteModel testeModel)
        {
            if (ModelState.IsValid)
            {
                db.TesteModels.Add(testeModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(testeModel);
        }

        // GET: TesteModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TesteModel testeModel = db.TesteModels.Find(id);
            if (testeModel == null)
            {
                return HttpNotFound();
            }
            return View(testeModel);
        }

        // POST: TesteModels/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cod_teste,texto")] TesteModel testeModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(testeModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(testeModel);
        }

        // GET: TesteModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TesteModel testeModel = db.TesteModels.Find(id);
            if (testeModel == null)
            {
                return HttpNotFound();
            }
            return View(testeModel);
        }

        // POST: TesteModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TesteModel testeModel = db.TesteModels.Find(id);
            db.TesteModels.Remove(testeModel);
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
