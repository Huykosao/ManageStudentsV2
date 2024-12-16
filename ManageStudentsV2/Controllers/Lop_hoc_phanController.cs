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
    public class Lop_hoc_phanController : Controller
    {
        private Quan_Ly_Sinh_Vien_Entities db = new Quan_Ly_Sinh_Vien_Entities();

        // GET: Lop_hoc_phan
        public ActionResult Index()
        {
            var lop_hoc_phan = db.Lop_hoc_phan.Include(l => l.Lop_chinh).Include(l => l.Mon_hoc);
            return View(lop_hoc_phan.ToList());
        }

        // GET: Lop_hoc_phan/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lop_hoc_phan lop_hoc_phan = db.Lop_hoc_phan.Find(id);
            if (lop_hoc_phan == null)
            {
                return HttpNotFound();
            }
            return View(lop_hoc_phan);
        }

        // GET: Lop_hoc_phan/Create
        public ActionResult Create()
        {
            ViewBag.ma_lop = new SelectList(db.Lop_chinh, "ma_lop", "ten_lop");
            ViewBag.ma_mon = new SelectList(db.Mon_hoc, "ma_mon", "ten_mon");
            return View();
        }

        // POST: Lop_hoc_phan/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ma_hoc_phan,ma_lop,ma_mon")] Lop_hoc_phan lop_hoc_phan)
        {
            if (ModelState.IsValid)
            {
                db.Lop_hoc_phan.Add(lop_hoc_phan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ma_lop = new SelectList(db.Lop_chinh, "ma_lop", "ten_lop", lop_hoc_phan.ma_lop);
            ViewBag.ma_mon = new SelectList(db.Mon_hoc, "ma_mon", "ten_mon", lop_hoc_phan.ma_mon);
            return View(lop_hoc_phan);
        }

        // GET: Lop_hoc_phan/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lop_hoc_phan lop_hoc_phan = db.Lop_hoc_phan.Find(id);
            if (lop_hoc_phan == null)
            {
                return HttpNotFound();
            }
            ViewBag.ma_lop = new SelectList(db.Lop_chinh, "ma_lop", "ten_lop", lop_hoc_phan.ma_lop);
            ViewBag.ma_mon = new SelectList(db.Mon_hoc, "ma_mon", "ten_mon", lop_hoc_phan.ma_mon);
            return View(lop_hoc_phan);
        }

        // POST: Lop_hoc_phan/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ma_hoc_phan,ma_lop,ma_mon")] Lop_hoc_phan lop_hoc_phan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lop_hoc_phan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ma_lop = new SelectList(db.Lop_chinh, "ma_lop", "ten_lop", lop_hoc_phan.ma_lop);
            ViewBag.ma_mon = new SelectList(db.Mon_hoc, "ma_mon", "ten_mon", lop_hoc_phan.ma_mon);
            return View(lop_hoc_phan);
        }

        // GET: Lop_hoc_phan/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lop_hoc_phan lop_hoc_phan = db.Lop_hoc_phan.Find(id);
            if (lop_hoc_phan == null)
            {
                return HttpNotFound();
            }
            return View(lop_hoc_phan);
        }

        // POST: Lop_hoc_phan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lop_hoc_phan lop_hoc_phan = db.Lop_hoc_phan.Find(id);
            db.Lop_hoc_phan.Remove(lop_hoc_phan);
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
