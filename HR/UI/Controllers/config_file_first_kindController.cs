using IOC;
using lntBLL;
using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class config_file_first_kindController : Controller
    {
        Iconfig_file_first_kindBLL isb = IocCreate.Createconfig_file_first_kindBLL();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2()
        {
            List<config_file_first_kindModel> list = isb.Select();
            return Content(JsonConvert.SerializeObject(list));
        }
        //public ActionResult Fill()
        //{

        //    return Content(JsonConvert.SerializeObject(list));
        //}

        public ActionResult Add()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Add(config_file_first_kindModel s)
        {

            // TODO: Add insert logic here
            if (isb.Add(s) > 0)
            {
                return Content("<script>alert('新增成功');window.location='Index'</script>");
            }
            else
            {
                ViewBag.dt = s;
            }
            return View();
        }

        public ActionResult Update(int id)
        {

            config_file_first_kindModel sd = new config_file_first_kindModel()
            {
                Id = short.Parse(id.ToString())
            };
            List<config_file_first_kindModel> list = isb.SelectBy(sd);
            config_file_first_kindModel st = new config_file_first_kindModel()
            {
                Id = list[0].Id,
                first_kind_id=list[0].first_kind_id,
                first_kind_name = list[0].first_kind_name,
                first_kind_salary_id = list[0].first_kind_salary_id,
                first_kind_sale_id = list[0].first_kind_sale_id,
            };
            return View(st);
        }
        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Update(config_file_first_kindModel u)
        {

            // TODO: Add update logic here
            if (isb.Update(u) > 0)
            {
                return JavaScript("alert('修改成功');window.location.href='/config_file_first_kind/Index'");
            }
            else
            {

                ViewBag.dt = u;
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            config_file_first_kindModel st = new config_file_first_kindModel()
            {
                Id = short.Parse(id.ToString())
            };
            if (isb.Del(st) > 0)
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