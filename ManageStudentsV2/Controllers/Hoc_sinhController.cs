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
    public class Hoc_sinhController : Controller
    {
        private Quan_Ly_Sinh_Vien_Entities db = new Quan_Ly_Sinh_Vien_Entities();

        // GET: Hoc_sinh
        public ActionResult Index()
        {
            var hoc_sinh = db.Hoc_sinh.Include(h => h.Lop_chinh);
            return View(hoc_sinh.ToList());
        }

        // GET: Hoc_sinh/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hoc_sinh hoc_sinh = db.Hoc_sinh.Find(id);
            if (hoc_sinh == null)
            {
                return HttpNotFound();
            }
            return View(hoc_sinh);
        }

        // GET: Hoc_sinh/Create
        public ActionResult Create()
        {
            ViewBag.ma_lop = new SelectList(db.Lop_chinh, "ma_lop", "ten_lop");
            return View();
        }

        // POST: Hoc_sinh/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ma_sinh_vien,ten_sinh_vien,ma_lop")] Hoc_sinh hoc_sinh)
        {
            if (ModelState.IsValid)
            {
                db.Hoc_sinh.Add(hoc_sinh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ma_lop = new SelectList(db.Lop_chinh, "ma_lop", "ten_lop", hoc_sinh.ma_lop);
            return View(hoc_sinh);
        }

        // GET: Hoc_sinh/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hoc_sinh hoc_sinh = db.Hoc_sinh.Find(id);
            if (hoc_sinh == null)
            {
                return HttpNotFound();
            }
            ViewBag.ma_lop = new SelectList(db.Lop_chinh, "ma_lop", "ten_lop", hoc_sinh.ma_lop);
            return View(hoc_sinh);
        }

        // POST: Hoc_sinh/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ma_sinh_vien,ten_sinh_vien,ma_lop")] Hoc_sinh hoc_sinh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hoc_sinh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ma_lop = new SelectList(db.Lop_chinh, "ma_lop", "ten_lop", hoc_sinh.ma_lop);
            return View(hoc_sinh);
        }

        // GET: Hoc_sinh/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hoc_sinh hoc_sinh = db.Hoc_sinh.Find(id);
            if (hoc_sinh == null)
            {
                return HttpNotFound();
            }
            return View(hoc_sinh);
        }

        // POST: Hoc_sinh/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Hoc_sinh hoc_sinh = db.Hoc_sinh.Find(id);
            db.Hoc_sinh.Remove(hoc_sinh);
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
