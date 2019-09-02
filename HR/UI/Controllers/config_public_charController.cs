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
    public class config_public_charController : Controller
    {
        Iconfig_public_charBLL ind = IocCreate.Createconfig_public_charBLL();
        // GET: config_public_char
        public ActionResult Index()
        {
           
            return View();
        }
        public ActionResult Index2()
        {
             config_public_charModel sd = new config_public_charModel()
            {
       
                attribute_kind = "职称"                          
            };
            List<config_public_charModel> list = ind.SelectBy(sd);
            return Content(JsonConvert.SerializeObject(list));
        }


        // GET: config_public_char/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: config_public_char/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: config_public_char/Create
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

        // GET: config_public_char/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: config_public_char/Edit/5
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

        // GET: config_public_char/Delete/5
        public ActionResult Delete(int id)
        {
            config_public_charModel ckm = new config_public_charModel()
            {
                Id = short.Parse(id.ToString())
            };
            if (ind.Del(ckm) > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
          
        }

        // POST: config_public_char/Delete/5
      
       
    }
}
