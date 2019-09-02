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
    public class config_majorController : Controller
    {
        Iconfig_majorBLL  cfm= IocCreate.Createconfig_majorBLL();
        // GET: config_major
        public ActionResult Index()
        {
           // Fill();
            return View();
        }
        public ActionResult Fill()
        {
            List<config_majorModel> list = cfm.Select();
            return Content(JsonConvert.SerializeObject(list));
        }
        // GET: config_major/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: config_major/Create
        public ActionResult Add()
        {

            return View();
        }

        // POST: config_major/Create
        [HttpPost]
        public ActionResult Add(config_majorModel con)
        {
            try
            {
                // TODO: Add insert logic here
                if (cfm.Add(con)>0)
                {
                    return Content("<script>alert('新增成功');window.location='Index'</script>");
                }
                else
                {
                    ViewBag.dt = con;
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: config_major/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: config_major/Edit/5
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

        // GET: config_major/Delete/5
        public ActionResult Delete(int id)
        {
            config_majorModel st = new config_majorModel()
            {
                Id = short.Parse(id.ToString())
            };
            if (cfm.Del(st) > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
           
        }

        // POST: config_major/Delete/5
      
    }
}
