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
    public class Lop_chinhController : Controller
    {
        private Quan_Ly_Sinh_Vien_Entities db = new Quan_Ly_Sinh_Vien_Entities();

        // GET: Lop_chinh
        public ActionResult Index()
        {
            var lop_chinh = db.Lop_chinh.Include(l => l.Giao_vien).Include(l => l.Nganh);
            return View(lop_chinh.ToList());
        }

        // GET: Lop_chinh/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lop_chinh lop_chinh = db.Lop_chinh.Find(id);
            if (lop_chinh == null)
            {
                return HttpNotFound();
            }
            return View(lop_chinh);
        }

        // GET: Lop_chinh/Create
        public ActionResult Create()
        {
            ViewBag.giao_vien_chu_nhiem = new SelectList(db.Giao_vien, "ma_giao_vien", "ten_giao_vien");
            ViewBag.ma_nganh = new SelectList(db.Nganhs, "ma_nganh", "ten_nganh");
            return View();
        }

        // POST: Lop_chinh/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ma_lop,ten_lop,giao_vien_chu_nhiem,ma_nganh")] Lop_chinh lop_chinh)
        {
            if (ModelState.IsValid)
            {
                db.Lop_chinh.Add(lop_chinh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.giao_vien_chu_nhiem = new SelectList(db.Giao_vien, "ma_giao_vien", "ten_giao_vien", lop_chinh.giao_vien_chu_nhiem);
            ViewBag.ma_nganh = new SelectList(db.Nganhs, "ma_nganh", "ten_nganh", lop_chinh.ma_nganh);
            return View(lop_chinh);
        }

        // GET: Lop_chinh/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lop_chinh lop_chinh = db.Lop_chinh.Find(id);
            if (lop_chinh == null)
            {
                return HttpNotFound();
            }
            ViewBag.giao_vien_chu_nhiem = new SelectList(db.Giao_vien, "ma_giao_vien", "ten_giao_vien", lop_chinh.giao_vien_chu_nhiem);
            ViewBag.ma_nganh = new SelectList(db.Nganhs, "ma_nganh", "ten_nganh", lop_chinh.ma_nganh);
            return View(lop_chinh);
        }

        // POST: Lop_chinh/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ma_lop,ten_lop,giao_vien_chu_nhiem,ma_nganh")] Lop_chinh lop_chinh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lop_chinh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.giao_vien_chu_nhiem = new SelectList(db.Giao_vien, "ma_giao_vien", "ten_giao_vien", lop_chinh.giao_vien_chu_nhiem);
            ViewBag.ma_nganh = new SelectList(db.Nganhs, "ma_nganh", "ten_nganh", lop_chinh.ma_nganh);
            return View(lop_chinh);
        }

        // GET: Lop_chinh/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lop_chinh lop_chinh = db.Lop_chinh.Find(id);
            if (lop_chinh == null)
            {
                return HttpNotFound();
            }
            return View(lop_chinh);
        }

        // POST: Lop_chinh/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lop_chinh lop_chinh = db.Lop_chinh.Find(id);
            db.Lop_chinh.Remove(lop_chinh);
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
