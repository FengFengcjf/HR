using IOC;
using lntBLL;
using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class config_file_second_kindController : Controller
    {
        Iconfig_file_second_kindBLL isb = IocCreate.Createconfig_file_second_kindBLL();
        Iconfig_file_first_kindBLL sb = IocCreate.Createconfig_file_first_kindBLL();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2()
        {
            List<config_file_second_kindModel> list = isb.Select();
            return Content(JsonConvert.SerializeObject(list));
        }

           public ActionResult Add()
        {
            List<config_file_first_kindModel> list = sb.Select();
            List<SelectListItem> listyj = new List<SelectListItem>();
            for (int i = 0; i < list.Count; i++)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = list[i].first_kind_name.ToString(),
                    Value = list[i].first_kind_id.ToString()
                };
                listyj.Add(sl);
            }         
            config_file_second_kindModel ctm = new config_file_second_kindModel();
            ViewData["yj"] = listyj;
            return View(ctm);
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Add(config_file_second_kindModel s)
        {

            try
            {
                config_file_first_kindModel cfm = new config_file_first_kindModel
                {
                    first_kind_id = s.first_kind_id
                };
                List<config_file_first_kindModel> listf = sb.SelectByName(cfm);
                s.first_kind_name = listf[0].first_kind_name;
                if (isb.Add(s) > 0)
                {
                    return Content("<script>alert('新增成功');window.location='Index'</script>");
                }
                else
                {
                    return Content("<script>alert('新增成功');window.location='Index'</script>");
                }
            }
            catch
            {
                return View(s);
            }
        }

        public ActionResult Update(int id)
        {

            config_file_second_kindModel sd = new config_file_second_kindModel()
            {
                Id = short.Parse(id.ToString())
            };
            List<config_file_second_kindModel> list = isb.SelectBy(sd);
            config_file_second_kindModel st = new config_file_second_kindModel()
            {
                Id = list[0].Id,
                first_kind_name = list[0].first_kind_name,
                second_kind_id = list[0].second_kind_id,
                second_kind_name = list[0].second_kind_name,
                second_salary_id = list[0].second_salary_id,
                second_sale_id = list[0].second_sale_id,
            };
            return View(st);
        }
        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Update(config_file_second_kindModel u)
        {

            // TODO: Add update logic here
            if (isb.Update(u) > 0)
            {
                return JavaScript("alert('修改成功');window.location.href='/config_file_second_kind/Index'");
            }
            else
            {

                ViewBag.dt = u;
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            config_file_second_kindModel st = new config_file_second_kindModel()
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