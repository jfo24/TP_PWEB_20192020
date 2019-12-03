using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TPVersao4.Models;

namespace TPVersao4.Controllers
{
    public class AluguersController : Controller
    {
        private GreenChargeContext db = new GreenChargeContext();

        // GET: Aluguers
        public ActionResult Index()
        {
            var aluguers = db.Aluguers.Include(a => a.Cliente).Include(a => a.Proprietario).Include(a => a.Veiculo);
            return View(aluguers.ToList());
        }

        // GET: Aluguers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aluguer aluguer = db.Aluguers.Find(id);
            if (aluguer == null)
            {
                return HttpNotFound();
            }
            return View(aluguer);
        }

        // GET: Aluguers/Create
        public ActionResult Create()
        {
            ViewBag.ClienteID = new SelectList(db.Clientes, "ClienteId", "ClienteNome");
            ViewBag.ProprietarioID = new SelectList(db.Proprietarios, "ProprietarioID", "ProprietarioNome");
            ViewBag.VeiculoID = new SelectList(db.Veiculos, "VeiculoID", "VeiculoID");
            return View();
        }

        // POST: Aluguers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AluguerId,ProprietarioID,VeiculoID,ClienteID")] Aluguer aluguer)
        {
            if (ModelState.IsValid)
            {
                db.Aluguers.Add(aluguer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ClienteID = new SelectList(db.Clientes, "ClienteId", "ClienteNome", aluguer.ClienteID);
            ViewBag.ProprietarioID = new SelectList(db.Proprietarios, "ProprietarioID", "ProprietarioNome", aluguer.ProprietarioID);
            ViewBag.VeiculoID = new SelectList(db.Veiculos, "VeiculoID", "VeiculoID", aluguer.VeiculoID);
            return View(aluguer);
        }

        // GET: Aluguers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aluguer aluguer = db.Aluguers.Find(id);
            if (aluguer == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClienteID = new SelectList(db.Clientes, "ClienteId", "ClienteNome", aluguer.ClienteID);
            ViewBag.ProprietarioID = new SelectList(db.Proprietarios, "ProprietarioID", "ProprietarioNome", aluguer.ProprietarioID);
            ViewBag.VeiculoID = new SelectList(db.Veiculos, "VeiculoID", "VeiculoID", aluguer.VeiculoID);
            return View(aluguer);
        }

        // POST: Aluguers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AluguerId,ProprietarioID,VeiculoID,ClienteID")] Aluguer aluguer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aluguer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ClienteID = new SelectList(db.Clientes, "ClienteId", "ClienteNome", aluguer.ClienteID);
            ViewBag.ProprietarioID = new SelectList(db.Proprietarios, "ProprietarioID", "ProprietarioNome", aluguer.ProprietarioID);
            ViewBag.VeiculoID = new SelectList(db.Veiculos, "VeiculoID", "VeiculoID", aluguer.VeiculoID);
            return View(aluguer);
        }

        // GET: Aluguers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aluguer aluguer = db.Aluguers.Find(id);
            if (aluguer == null)
            {
                return HttpNotFound();
            }
            return View(aluguer);
        }

        // POST: Aluguers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Aluguer aluguer = db.Aluguers.Find(id);
            db.Aluguers.Remove(aluguer);
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
