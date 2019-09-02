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
namespace UI.Content
{
    public class usersController : Controller
    {
        IusersBLL ius = IocCreate.CreateusersBLL();
        IGuanliBLL gb = IocCreate.CreateGuanliBLL();
        // GET: users
      
        public ActionResult Index()
        {
            //Fill();
            return View();
        }
       
        
        public ActionResult Login(usersModel u)
        {
        
            usersModel dt = ius.Login(u);
            //if (dt.Available == "否")
            //{
            //    return JavaScript("alert('您没有权限登录!!');window.location.href='/users/Index'");
            //}
            //else
            //{
                if (dt != null)
                {
                    return JavaScript("alert('登录成功!');localStorage.setItem('a','" + dt.u_name + "'); localStorage.setItem('b','" + dt.Gid
                        + "');localStorage.setItem('c','" + dt.Id + "') ;       window.location.href='/users/QX'");

                }
                else
                {
                    return JavaScript("alert('登录失败!请重新输入账号或密码!!');window.location.href='/users/Index'");
                }
            //}
          

        }
        public ActionResult Fill()
        {
            List<usersModel> list = ius.Select();
            return Content(JsonConvert.SerializeObject(list));
        }

        public ActionResult show(usersModel u)
        {
            string id = Request["id"];
            int gid = u.Gid;
            //object dt =ius.JXMain(gid, id);
            //return Content(JsonConvert.SerializeObject(dt));

            string sql = "";
            if (id != null)
            {
                //查询子集                   
                sql = string.Format(@"select* from 
[dbo].[Pop] q inner join   [dbo].[GuanliPop] rq on
q.id=rq.PopID where rq.GuanliID={0} and q.PID={1}", gid, id);
            }
            else
            {
                //查询父集
                sql = string.Format(@"select id,[text],PAddress,[state] from 
[dbo].[Pop] q inner join   [dbo].[GuanliPop] rq on
q.id=rq.PopID where rq.GuanliID={0} and q.PID=0
", gid);
            }

            DataTable dt = DBHelper.SelectTable(sql);
            return Content(JsonConvert.SerializeObject(dt));
        }

        public ActionResult QX()
        {
            return View();
        }
        public ActionResult top()
        {
            //    GuanliModel g = new GuanliModel()
            //    {
            //        Id = id
            //    };
            //List<GuanliModel> dt= gb.SelectBy(g);
            //    return Content(JsonConvert.SerializeObject(dt));
            return View();
        }
        public ActionResult left()
        {
            return View();
        }
        public ActionResult main()
        {
            return View();
        }

        // GET: users/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: users/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: users/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: users/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: users/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: users/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
