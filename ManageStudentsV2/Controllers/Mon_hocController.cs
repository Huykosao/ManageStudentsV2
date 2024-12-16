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
    public class Mon_hocController : Controller
    {
        private Quan_Ly_Sinh_Vien_Entities db = new Quan_Ly_Sinh_Vien_Entities();

        // GET: Mon_hoc
        public ActionResult Index()
        {
            return View(db.Mon_hoc.ToList());
        }

        // GET: Mon_hoc/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mon_hoc mon_hoc = db.Mon_hoc.Find(id);
            if (mon_hoc == null)
            {
                return HttpNotFound();
            }
            return View(mon_hoc);
        }

        // GET: Mon_hoc/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mon_hoc/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ma_mon,ten_mon,mo_ta_mon")] Mon_hoc mon_hoc)
        {
            if (ModelState.IsValid)
            {
                db.Mon_hoc.Add(mon_hoc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mon_hoc);
        }

        // GET: Mon_hoc/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mon_hoc mon_hoc = db.Mon_hoc.Find(id);
            if (mon_hoc == null)
            {
                return HttpNotFound();
            }
            return View(mon_hoc);
        }

        // POST: Mon_hoc/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ma_mon,ten_mon,mo_ta_mon")] Mon_hoc mon_hoc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mon_hoc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mon_hoc);
        }

        // GET: Mon_hoc/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mon_hoc mon_hoc = db.Mon_hoc.Find(id);
            if (mon_hoc == null)
            {
                return HttpNotFound();
            }
            return View(mon_hoc);
        }

        // POST: Mon_hoc/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mon_hoc mon_hoc = db.Mon_hoc.Find(id);
            db.Mon_hoc.Remove(mon_hoc);
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
