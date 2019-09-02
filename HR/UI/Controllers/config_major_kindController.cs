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
    public class config_major_kindController : Controller
    {
        Iconfig_major_kindBLL ind = IocCreate.Createconfig_major_kindBLL();
        // GET: config_major_kind
        public ActionResult Index()
        {
            List<config_major_kindModel> list = ind.Select();
            return View(list);
        }

        // GET: config_major_kind/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: config_major_kind/Create
        public ActionResult Add()
        {
            return View();
        }

        // POST: config_major_kind/Create
        [HttpPost]
        public ActionResult Add(config_major_kindModel c)
        {
         
        
                // TODO: Add insert logic here
                if (ind.Add(c)>0)
                {
                    return Content("<script>alert('新增成功');window.location='Index'</script>");
                }
                else
                {
           //     return Content("<script>alert('新增失败');window.location='Index'</script>");
                    ViewBag.dt = c;
                }
          
                return View();
            }
        

        // GET: config_major_kind/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: config_major_kind/Edit/5
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

        // GET: config_major_kind/Delete/5
        public ActionResult Delete(int id)
        {
            config_major_kindModel ckm = new config_major_kindModel()
            {
                Id=short.Parse( id.ToString())
            };
            if (ind.Del(ckm)>0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        // POST: config_major_kind/Delete/5
       
        }
    }

