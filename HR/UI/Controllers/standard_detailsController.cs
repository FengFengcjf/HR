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

    


        // GET: standard_details/Create
        public ActionResult Add()
        {
            return View();
        }

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

       
    }
}
