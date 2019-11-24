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
    public class AnotacoesController : Controller
    {
        private DBContext db = new DBContext();

        // GET: Anotacoes
        public ActionResult Index()
        {
            return View(db.AnotacoesModels.ToList());
        }

        // GET: Anotacoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnotacoesModel anotacoesModel = db.AnotacoesModels.Find(id);
            if (anotacoesModel == null)
            {
                return HttpNotFound();
            }
            return View(anotacoesModel);
        }

        // GET: Anotacoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Anotacoes/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cod_anotacao,texto")] AnotacoesModel anotacoesModel)
        {
            if (ModelState.IsValid)
            {
                db.AnotacoesModels.Add(anotacoesModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(anotacoesModel);
        }

        // GET: Anotacoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnotacoesModel anotacoesModel = db.AnotacoesModels.Find(id);
            if (anotacoesModel == null)
            {
                return HttpNotFound();
            }
            return View(anotacoesModel);
        }

        // POST: Anotacoes/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cod_anotacao,texto")] AnotacoesModel anotacoesModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(anotacoesModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(anotacoesModel);
        }

        // GET: Anotacoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnotacoesModel anotacoesModel = db.AnotacoesModels.Find(id);
            if (anotacoesModel == null)
            {
                return HttpNotFound();
            }
            return View(anotacoesModel);
        }

        // POST: Anotacoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AnotacoesModel anotacoesModel = db.AnotacoesModels.Find(id);
            db.AnotacoesModels.Remove(anotacoesModel);
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
