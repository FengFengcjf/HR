using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IOC;
using Model;
using lntBLL;
using BLL;
using Newtonsoft.Json;

namespace UI.Content
{
    public class JurisdictionController : Controller
    {
        IGuanliBLL gb = IocCreate.CreateGuanliBLL();
        // GET: Jurisdiction
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Select(int id)
        {
            Dictionary<string, object> list = gb.Fenye(id);
            return Content(JsonConvert.SerializeObject(list));

        }

        // GET: Jurisdiction/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Jurisdiction/Create
        public ActionResult Create()
        {
            FillDrop();
            return View();
        }

        // POST: Jurisdiction/Create
        [HttpPost]
        public ActionResult Create(GuanliModel g)
        {
            if (gb.Add(g)>0)
            {

                return Content("<script>alert('新增成功');window.location='Index'</script>");
            }
            else
            {
                ViewBag.dt = g;
            }
            return View();
        }
        private void FillDrop()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<GuanliModel> dt = gb.Select();
            foreach (GuanliModel dr in dt)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = dr.Available,
                    Value = dr.Id.ToString()

                };
                list.Add(sl);
            }
            ViewBag.dt = list;
        }

        // GET: Jurisdiction/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Jurisdiction/Edit/5
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
           GuanliModel s = new GuanliModel
            {
                Id=id
            };
            if (gb.Del(s) > 0)
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
