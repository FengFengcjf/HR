using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IOC;
using Model;
using BLL;
using lntBLL;
using Newtonsoft.Json;

namespace UI.Controllers
{
    public class usersGuanliController : Controller
    {

        IGuanliBLL gl = IocCreate.CreateGuanliBLL();
        IusersBLL us = IocCreate.CreateusersBLL();
        // GET: usersGuanli
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Select(int id)
        {
            //List<usersModel> dt = us.Select();
            //return Content(JsonConvert.SerializeObject(dt));
            Dictionary<string, object> list = us.Fenye(id);
            return Content(JsonConvert.SerializeObject(list));
        }
        private void FillDrop()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<GuanliModel> dt = gl.Select();
            foreach (GuanliModel dr in dt)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = dr.gname,
                    Value = dr.Id.ToString()
                };
                list.Add(sl);
            }
            ViewBag.dt = list;
        }
        // GET: usersGuanli/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: usersGuanli/Create
        public ActionResult Create()
        {
            FillDrop();
            return View();
        }

        // POST: usersGuanli/Create
        [HttpPost]
        public ActionResult Create(usersModel u)
        {
              GuanliModel gu = new GuanliModel();

            usersModel pt = new usersModel()
            {
                u_name=u.u_name,
                u_password=u.u_password,
                u_true_name=u.u_true_name,
                Gid = u.Id

            };
            if (us.Add(pt) > 0)
            {
                return Content("<script>alert('新增成功');window.location='Index'</script>");
            }
            else
            {
                ViewBag.dt = u;
            }
            return View();
        }

        // GET: usersGuanli/Edit/5
        public ActionResult Edit(int id)
        {       
           usersModel sd = new usersModel()
            {
                Id = id
            };
            List<usersModel> list = us.SelectBy(sd);
            usersModel st = new usersModel()
            {
                Id = list[0].Id,
                u_name=list[0].u_name,
                u_password=list[0].u_password,
                u_true_name=list[0].u_true_name,
                Gid=list[0].Gid
                
            };
            ViewData.Model = st;
            FillDrop();
            return View(st);         
        }

        // POST: usersGuanli/Edit/5
        [HttpPost]
        public ActionResult Edit(usersModel um)
        {
           
                if (us.Update(um) > 0)
                {
                    return JavaScript("alert('修改成功');window.location.href='/usersGuanli/Index'");
                }
                else
                {

                    ViewBag.dt = um;
                   return View();
            }
            
            
            
        }

     
        public ActionResult Delete(int id)
        {
            usersModel s = new usersModel()
            {
                Id = id
            };
            if (us.Del(s) > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}
