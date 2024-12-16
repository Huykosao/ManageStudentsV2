using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ManageStudentsV2.Models;

namespace ManageStudentsV2.Controllers
{
    public class Lich_hocController : Controller
    {
        private Quan_Ly_Sinh_Vien_Entities db = new Quan_Ly_Sinh_Vien_Entities();

        // GET: Lich_hoc
        public ActionResult Index()
        {
            var lich_hoc = db.Lich_hoc.Include(l => l.Lop_hoc_phan);
            return View(lich_hoc.ToList());
        }

        // GET: Lich_hoc/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lich_hoc lich_hoc = db.Lich_hoc.Find(id);
            if (lich_hoc == null)
            {
                return HttpNotFound();
            }
            return View(lich_hoc);
        }

        // GET: Lich_hoc/Create
        public ActionResult Create()
        {
            ViewBag.ma_hoc_phan = new SelectList(db.Lop_hoc_phan, "ma_hoc_phan", "ma_hoc_phan");
            return View();
        }

        // POST: Lich_hoc/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ma_lich,thoi_gian,phong_hoc,ma_hoc_phan")] Lich_hoc lich_hoc)
        {
            if (ModelState.IsValid)
            {
                db.Lich_hoc.Add(lich_hoc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ma_hoc_phan = new SelectList(db.Lop_hoc_phan, "ma_hoc_phan", "ma_hoc_phan", lich_hoc.ma_hoc_phan);
            return View(lich_hoc);
        }

        // GET: Lich_hoc/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lich_hoc lich_hoc = db.Lich_hoc.Find(id);
            if (lich_hoc == null)
            {
                return HttpNotFound();
            }
            ViewBag.ma_hoc_phan = new SelectList(db.Lop_hoc_phan, "ma_hoc_phan", "ma_hoc_phan", lich_hoc.ma_hoc_phan);
            return View(lich_hoc);
        }

        // POST: Lich_hoc/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ma_lich,thoi_gian,phong_hoc,ma_hoc_phan")] Lich_hoc lich_hoc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lich_hoc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ma_hoc_phan = new SelectList(db.Lop_hoc_phan, "ma_hoc_phan", "ma_hoc_phan", lich_hoc.ma_hoc_phan);
            return View(lich_hoc);
        }

        // GET: Lich_hoc/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lich_hoc lich_hoc = db.Lich_hoc.Find(id);
            if (lich_hoc == null)
            {
                return HttpNotFound();
            }
            return View(lich_hoc);
        }

        // POST: Lich_hoc/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lich_hoc lich_hoc = db.Lich_hoc.Find(id);
            db.Lich_hoc.Remove(lich_hoc);
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
