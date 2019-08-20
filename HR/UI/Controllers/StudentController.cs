using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lntBLL;
using BLL;
using IOC;
using Model;
using System.Data;

namespace UI.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        //ISstandard_detailsBLL isb = IocCreate.CreateStudentBLL();
        //public ActionResult Index()
        //{
        //    List<standard_detailsModel> list = isb.StudentSelect();
        //    return View(list);
        //}

        //// GET: Student/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Student/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Student/Create
        //[HttpPost]
        //public ActionResult Create(standard_detailsModel s)
        //{

        //    // TODO: Add insert logic here
        //    if (isb.StudentAdd(s) > 0)
        //    {
        //        return Content("<script>alert('新增成功');window.location='Index'</script>");
        //    }
        //    else
        //    {
        //        ViewBag.dt = s;
        //    }
        //    return View();
        //}
        //// GET: Student/Edit/5
        //public ActionResult Edit(int id)
        //{

        //    standard_detailsModel sd = new standard_detailsModel()
        //    {
        //        Id = id
        //    };
        //    List<standard_detailsModel> list = isb.SelectBy(sd);
        //    standard_detailsModel st = new standard_detailsModel()
        //    {
        //        Id = list[0].Id,
        //        Name = list[0].Name

        //    };
        //    return View(st);
        //}
        //// POST: Student/Edit/5
        //[HttpPost]
        //public ActionResult Edit(standard_detailsModel u)
        //{

        //    // TODO: Add update logic here
        //    if (isb.StudentUpdate(u) > 0)
        //    {
        //        return JavaScript("alert('修改成功');window.location.href='/Student/Index'");
        //    }
        //    else
        //    {

        //        ViewBag.dt = u;
        //    }

        //    return View();
        //}





        //// GET: Student/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    standard_detailsModel st = new standard_detailsModel(){
        //        Id =id
        //    };
        //    if (isb.StudentDel(st)>0)
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    //
        //}

        //// POST: Student/Delete/5

    
    }
}