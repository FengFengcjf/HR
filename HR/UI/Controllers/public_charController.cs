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
namespace UI.Content.Controllers
{
    public class public_charController : Controller
    {
        Iconfig_public_charBLL ind = IocCreate.Createconfig_public_charBLL();
        // GET: public_char
        public ActionResult Index()
        {
            //List<public_charModel> list= pc.Select();
            //return View(list);
            Fill();
            return View();
        
        }

        public ActionResult Fill()
        {
            List<config_public_charModel> list = ind.Select();
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult Select()
        {
            List<config_public_charModel> dt = ind.Select();
            return Content(JsonConvert.SerializeObject(dt));
        }

        // GET: public_char/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: public_char/Create
        public ActionResult Create()
        {
            return View();
        }

        // 新增
        [HttpPost]
        public ActionResult Create(config_public_charModel pcm)
        {
            if (ind.Add(pcm) > 0)
            {
                return Content("<script>alert('新增成功');window.location='Index'</script>");
            }
            else
            {
                ViewBag.dt = pcm;
            }
            return View();
        }

        // GET: public_char/Edit/5
        [HttpGet]
        //public ActionResult Edit(int id)
        //{

        //  public_charModel sd = new public_charModel()
        //    {
        //        Id = id
        //    };
        //    List<public_charModel> list = pc.SelectBy(sd);
        //    public_charModel st = new public_charModel()
        //    {
        //        Id = list[0].Id,
        //        attribute_kind=list[0].attribute_kind,
        //        attribute_name=list[0].attribute_name      
        //    };
        //    return View(st);
        //}

        //// POST: public_char/Edit/5
        //[HttpPost]
        //public ActionResult Edit(public_charModel st)
        //{
            
        //    if (pc.Update(st) > 0)
        //    {
        //        return JavaScript("alert('修改成功');window.location.href='/public_char/Index'");
        //        //return Content("<script>alert('修改成功');window.location='Index'</script>");
        //    }
        //    else
        //    {
        //        ViewBag.dt = st;
        //    }
        //    return View();
        //}
       
       
        public ActionResult Delete(int id)
        {
            config_public_charModel pcs = new config_public_charModel() {
                Id=short.Parse(id.ToString())
            };
            if (ind.Del(pcs)>0)
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
