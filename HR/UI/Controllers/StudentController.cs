using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lntBLL;
using BLL;
using IOC;
using Model;
using Commnd;
using System.Data;
using Newtonsoft.Json;

namespace UI.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        IStudentBLL isb = IocCreate.CreateStudentBLL();
        public ActionResult Index()
        {
            Fill();
            //List<StudentModel> list = isb.StudentSelect();
            return View();
        }
        public ActionResult Fill()
        {
            List<StudentModel> list = isb.StudentSelect();
            return Content(JsonConvert.SerializeObject(list));
        }
        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(StudentModel s)
        {

            // TODO: Add insert logic here
            if (isb.StudentAdd(s) > 0)
            {
                return Content("<script>alert('新增成功');window.location='Index'</script>");
            }
            else
            {
                ViewBag.dt = s;
            }
            return View();
        }
        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {

            StudentModel sd = new StudentModel()
            {
                Id = id
            };
            List<StudentModel> list = isb.SelectBy(sd);
            StudentModel st = new StudentModel()
            {
                Id = list[0].Id,
                Name = list[0].Name

            };  
            return View(st);
        }
        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(StudentModel u)
        {
         
            try
            {
                // TODO: Add update logic here
                if (isb.StudentUpdate(u) > 0)
                {
                    return JavaScript("alert('修改成功');window.location.href='/Student/Index'");
                }
                else
                {

                    ViewBag.dt = u;
                }
            }
            catch (Exception ex)
            {

            //    LogHelper.WriteLog(ex.Message);
            }
            return View();
        }





        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            StudentModel st = new StudentModel(){
                Id =id
            };
            if (isb.StudentDel(st)>0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
            //
        }

        // POST: Student/Delete/5

    
    }
}