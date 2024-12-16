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
    public class Nien_khoaController : Controller
    {
        private Quan_Ly_Sinh_Vien_Entities db = new Quan_Ly_Sinh_Vien_Entities();

        // GET: Nien_khoa
        public ActionResult Index()
        {
            var nien_khoa = db.Nien_khoa.Include(n => n.Khoa);
            return View(nien_khoa.ToList());
        }

        // GET: Nien_khoa/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nien_khoa nien_khoa = db.Nien_khoa.Find(id);
            if (nien_khoa == null)
            {
                return HttpNotFound();
            }
            return View(nien_khoa);
        }

        // GET: Nien_khoa/Create
        public ActionResult Create()
        {
            ViewBag.ma_khoa = new SelectList(db.Khoas, "ma_khoa", "ten_khoa");
            return View();
        }

        // POST: Nien_khoa/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ma_nien_khoa,ten_nien_khoa,nam_bat_dau,nam_ket_thuc,ma_khoa")] Nien_khoa nien_khoa)
        {
            if (ModelState.IsValid)
            {
                db.Nien_khoa.Add(nien_khoa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ma_khoa = new SelectList(db.Khoas, "ma_khoa", "ten_khoa", nien_khoa.ma_khoa);
            return View(nien_khoa);
        }

        // GET: Nien_khoa/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nien_khoa nien_khoa = db.Nien_khoa.Find(id);
            if (nien_khoa == null)
            {
                return HttpNotFound();
            }
            ViewBag.ma_khoa = new SelectList(db.Khoas, "ma_khoa", "ten_khoa", nien_khoa.ma_khoa);
            return View(nien_khoa);
        }

        // POST: Nien_khoa/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ma_nien_khoa,ten_nien_khoa,nam_bat_dau,nam_ket_thuc,ma_khoa")] Nien_khoa nien_khoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nien_khoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ma_khoa = new SelectList(db.Khoas, "ma_khoa", "ten_khoa", nien_khoa.ma_khoa);
            return View(nien_khoa);
        }

        // GET: Nien_khoa/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nien_khoa nien_khoa = db.Nien_khoa.Find(id);
            if (nien_khoa == null)
            {
                return HttpNotFound();
            }
            return View(nien_khoa);
        }

        // POST: Nien_khoa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Nien_khoa nien_khoa = db.Nien_khoa.Find(id);
            db.Nien_khoa.Remove(nien_khoa);
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
