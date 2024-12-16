using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManageStudentsV2.Controllers
{
    public class ManageStudentHomeController : Controller
    {
        // GET: ManageStudentHome
        public ActionResult Index()
        {
            //var students = _context.Students.ToList();
            ViewBag.Title = "Manage Student Home";
            return View();
        }

        public ActionResult ClassView()
        {
            ViewBag.Message = "Class manage";
            return View();
        }
    }
}