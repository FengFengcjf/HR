using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IOC;
using Model;
using lntBLL;
using Newtonsoft.Json;

namespace UI.Controllers
{
    public class standard_detailsController : Controller
    {
        ISstandard_detailsBLL sd = IocCreate.Createstandard_detailsBLL();
        // GET: standard_details
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Select()
        {
            List<standard_detailsModel> dt = sd.Select();
            return Content(JsonConvert.SerializeObject(dt));
        }

        // GET: standard_details/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: standard_details/Create
        public ActionResult Add()
        {
            return View();
        }

        // POST: standard_details/Create
        [HttpPost]
        public ActionResult Add(standard_detailsModel std)
        {
                if (sd.Add(std) > 0)
            {
                return Content("<script>alert('新增成功');window.location='Index'</script>");
            }
            else
            {
                ViewBag.dt = std;
            }
            return View();
        }

        // GET: standard_details/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: standard_details/Edit/5
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

         
        public ActionResult Delete(int id)
        {
           standard_detailsModel s = new standard_detailsModel()
            {
                Id = id
            };
            if (sd.Del(s) > 0)
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
