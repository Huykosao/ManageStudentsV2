﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;
using System.Web.UI;
using System.Web.WebPages;
using System.Web.WebPages.Html;

#line 2 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\3\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
using PagedList.Mvc;

#line default
#line hidden

public class _Page_Index_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_Index_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\3\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
__o = model;


#line default
#line hidden

#line 3 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\3\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
  
    ViewBag.Title = "Danh sách Lớp Chính";
    Layout = "~/Views/Shared/_ManageStudentHome.cshtml";


#line default
#line hidden

#line 4 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\3\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
   __o = Html.ActionLink("+ Thêm Lớp", "Create", null, new { @class = "btnAdd" });


#line default
#line hidden

#line 5 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\3\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
        if (Model != null && Model.Any())
        {
            foreach (var item in Model)
            {
                

#line default
#line hidden

#line 6 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\3\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
                   __o = Html.DisplayFor(modelItem => item.TenLop);


#line default
#line hidden

#line 7 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\3\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
                   __o = Html.DisplayFor(modelItem => item.SoLuongHocSinh);


#line default
#line hidden

#line 8 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\3\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
                   __o = Html.DisplayFor(modelItem => item.GiaoVien);


#line default
#line hidden

#line 9 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\3\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
                   __o = Html.DisplayFor(modelItem => item.Nganh);


#line default
#line hidden

#line 10 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\3\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
                   __o = Html.DisplayFor(modelItem => item.NienKhoa);


#line default
#line hidden

#line 11 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\3\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
                   __o = Html.DisplayFor(modelItem => item.Khoa);


#line default
#line hidden

#line 12 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\3\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
                   __o = Html.ActionLink("Edit", "Edit", new { id = item.MaLop }, new { @class = "btnEdit" });


#line default
#line hidden

#line 13 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\3\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
                   __o = Html.ActionLink("Details", "Details", new { id = item.MaLop }, new { @class = "btnDetails" });


#line default
#line hidden

#line 14 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\3\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
                   __o = Html.ActionLink("Delete", "Delete", new { id = item.MaLop }, new { @class = "btnDelete" });


#line default
#line hidden

#line 15 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\3\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
                     
            }
        }
        else
        {
            

#line default
#line hidden

#line 16 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\3\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
                 
        }

#line default
#line hidden

#line 17 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\3\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
        using (Html.BeginForm("Index", "Lop_chinh", FormMethod.Get))
        {

#line default
#line hidden

#line 18 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\3\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
                          __o = Html.DropDownList("size", (List<SelectListItem>)ViewBag.size, new { @onchange = "this.form.submit();" });


#line default
#line hidden

#line 19 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\3\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
                                                                                                                                             }

#line default
#line hidden

#line 20 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\3\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
                               __o = Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber;


#line default
#line hidden

#line 21 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\3\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
                                                                                             __o = Model.PageCount;


#line default
#line hidden

#line 22 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\3\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
__o = Html.PagedListPager(Model, page => Url.Action("Index", new { page, size = ViewBag.currentSize }));


#line default
#line hidden
}
}
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;
using System.Web.UI;
using System.Web.WebPages;
using System.Web.WebPages.Html;

#line 2 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\2\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
using PagedList.Mvc;

#line default
#line hidden

public class _Page_Index_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_Index_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\2\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
__o = model;


#line default
#line hidden

#line 3 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\2\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
  
    ViewBag.Title = "Danh sách Lớp Chính";
    Layout = "~/Views/Shared/_ManageStudentHome.cshtml";


#line default
#line hidden

#line 4 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\2\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
   __o = Html.ActionLink("+ Thêm Lớp", "Create", null, new { @class = "btnAdd" });


#line default
#line hidden

#line 5 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\2\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
        if (Model != null && Model.Any())
        {
            foreach (var item in Model)
            {
                

#line default
#line hidden

#line 6 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\2\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
                   __o = Html.DisplayFor(modelItem => item.TenLop);


#line default
#line hidden

#line 7 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\2\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
                   __o = Html.DisplayFor(modelItem => item.SoLuongHocSinh);


#line default
#line hidden

#line 8 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\2\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
                   __o = Html.DisplayFor(modelItem => item.GiaoVien);


#line default
#line hidden

#line 9 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\2\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
                   __o = Html.DisplayFor(modelItem => item.Nganh);


#line default
#line hidden

#line 10 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\2\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
                   __o = Html.DisplayFor(modelItem => item.NienKhoa);


#line default
#line hidden

#line 11 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\2\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
                   __o = Html.DisplayFor(modelItem => item.Khoa);


#line default
#line hidden

#line 12 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\2\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
                   __o = Html.ActionLink("Edit", "Edit", new { id = item.MaLop }, new { @class = "btnEdit" });


#line default
#line hidden

#line 13 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\2\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
                   __o = Html.ActionLink("Details", "Details", new { id = item.MaLop }, new { @class = "btnDetails" });


#line default
#line hidden

#line 14 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\2\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
                   __o = Html.ActionLink("Delete", "Delete", new { id = item.MaLop }, new { @class = "btnDelete" });


#line default
#line hidden

#line 15 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\2\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
                     
            }
        }
        else
        {
            

#line default
#line hidden

#line 16 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\2\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
                 
        }

#line default
#line hidden

#line 17 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\2\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
        using (Html.BeginForm("Index", "Lich_hoc", FormMetho         {
     {

#line default
#line hidden

#line 18 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\2\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
                          __o = Html.DropDownList("size", (List<SelectListItem>)ViewBag.size, new { @onchange = "this.form.submit();" });


#line default
#line hidden

#line 19 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\2\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.c                                                                                                                                             }

#line default
#line hidden

#line 20 "C:\Users\trant\AppData\Local\Temp\2C003857BCE22DFC0094D35884325122BBCC\2\ManageStudentsV2-master\ManageStudentsV2\Views\Lop_chinh\Index.cshtml"
shtml"
                               __o = Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber;


#line default
#line hidden
                                                                                             __o = Model.PageCount;


#line default
#line hidden
__o = Html.PagedListPager(Model, page => Url.Action("Index", new { page, size = ViewBag.currentSize }));


#line default
#line hidden
}
}
}