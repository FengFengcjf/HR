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
        // GET: users
        public ActionResult Index()
        {
            Fill();
            return View();
        }
        public ActionResult Fill()
        {
            List<usersModel> list = ius.Select();
            return Content(JsonConvert.SerializeObject(list));
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
