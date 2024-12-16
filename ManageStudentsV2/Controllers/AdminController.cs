using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManageStudentsV2.Controllers
{
    public class AdminController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection collection)
        {
            //var tendn collection["username"];
            //var matkhau collection["password"];
            //if (String.IsNullOrEmpty(tendn))
            //{
            //    ViewData["Loi1"] = "Phải nhập tên đăng nhập"; 

            //} else if (String.IsNullOrEmpty(matkhau))
            //{
            //    ViewData["Loi2"] = "Phải nhập mật khẩu";
            //}
            //else
            //{
            //    Admin ad db.Admins.SingleOrDefault(n => n.Username == tendn && n.PassAdmin == matkhau);

            //    if (ad != null)
            //    {
            //        Session["Taikhoanadmin"] = ad;
            //        return RedirectToAction("Index", "Admin");
            //    }
            //    else
            //        ViewBag.ThongBao = "Tên Đăng Nhập Hoặc Mặt Khẩu Không đúng ";
            // } 
            return View();
        }

    }
}