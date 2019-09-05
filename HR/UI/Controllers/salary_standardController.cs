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
    public class salary_standardController : Controller
    {
        ISstandard_detailsBLL sd = IocCreate.Createstandard_detailsBLL();
        // GET: salary_standard
        public ActionResult Index()
        {
            return View();
        }

        // GET: salary_standard/Details/5
        public ActionResult Index2()
        {
            List<standard_detailsModel> list = sd.Select();
            return Content(JsonConvert.SerializeObject(list));
        }

    }
}
