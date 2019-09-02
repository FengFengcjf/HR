using IOC;
using lntBLL;
using Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class engage_major_releaseController : Controller
    {
        Iconfig_file_first_kindBLL ib = IocCreate.Createconfig_file_first_kindBLL();
        Iconfig_file_third_kindBLL isb = IocCreate.Createconfig_file_third_kindBLL();
        Iconfig_file_second_kindBLL sb = IocCreate.Createconfig_file_second_kindBLL();
        Iconfig_major_kindBLL ia= IocCreate.Createconfig_major_kindBLL();
        Iconfig_majorBLL iii = IocCreate.Createconfig_majorBLL();
        Iengage_major_releaseBLL re = IocCreate.Createengage_major_releaseBLL();

        public ActionResult Index()
        {
            ViewData["rows"] = re.Row();
            ViewData["page"] = re.Pages();
            return View();
        }

        public ActionResult Index2()
        {
            IsoDateTimeConverter timeConverter = new IsoDateTimeConverter { DateTimeFormat = "yyyy'-'MM'-'dd HH':'mm':'ss" };
            List<engage_major_releaseModel> list = re.Fenye(int.Parse(Request["dqy"]));
            return Content(JsonConvert.SerializeObject(list,Formatting.Indented,timeConverter));
        }

        public ActionResult Index3()
        {
            ViewData["rows"] = re.Row();
            ViewData["page"] = re.Pages();
            return View();
        }

        public ActionResult Add()
        {
            List<config_file_first_kindModel> list = ib.Select();
            List<config_file_second_kindModel> li = sb.Select();
            List<config_major_kindModel> lll = ia.Select();
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
            List<SelectListItem> listej = new List<SelectListItem>();
            for (int i = 0; i < list.Count; i++)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = li[i].second_kind_name.ToString(),
                    Value = li[i].second_kind_id.ToString()
                };
                listej.Add(sl);
            }
            List<SelectListItem> liss = new List<SelectListItem>();
            for (int i = 0; i < lll.Count; i++)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = lll[i].major_kind_name.ToString(),
                    Value = lll[i].major_kind_id.ToString()
                };
                liss.Add(sl);
            }
            engage_major_releaseModel ctm = new engage_major_releaseModel();
            ViewData["yj"] = listyj;
            ViewData["jj"] = liss;
            ViewData["ej"] = listej;
            return View(ctm);
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Add(engage_major_releaseModel s)
        {
            
                config_file_second_kindModel csm = new config_file_second_kindModel
                {
                    second_kind_id = s.second_kind_id
                };
                config_file_first_kindModel cfm = new config_file_first_kindModel
                {
                    first_kind_id = s.first_kind_id
                };
                config_file_third_kindModel css = new config_file_third_kindModel
                {
                    third_kind_id = s.third_kind_id
                };
                config_major_kindModel cff = new config_major_kindModel
                {
                    major_kind_id = s.major_kind_id
                };
                config_majorModel cmm = new config_majorModel
                {
                    major_id = s.major_id,
                    major_kind_id=s.major_kind_id
                };
                List<config_file_second_kindModel> lists = sb.SelectByName(csm);
                List<config_file_first_kindModel> listf = ib.SelectByName(cfm);
                List<config_file_third_kindModel> lis = isb.SelectByName(css);
                List<config_major_kindModel> liss = ia.SelectByName(cff);
                List<config_majorModel> litt = iii.SelectByName(cmm);
                
                s.second_kind_name = lists[0].second_kind_name;
                s.first_kind_name = listf[0].first_kind_name;
                s.third_kind_name = lis[0].third_kind_name;
                s.major_kind_name = liss[0].major_kind_name;
                s.major_name = litt[0].major_name;
                s.change_time = DateTime.Now;
                if (re.Add(s) > 0)
                {
                    return Content("<script>alert('新增成功');window.location='Index'</script>");
                }
                else
                {
                    return Content("<script>alert('新增成功');window.location='Index'</script>");
                }
            
            
                
            
        }
        public ActionResult SeByy()
        {
            String Id = Request["sid"];
            List<config_file_second_kindModel> list = sb.SeBy(Id);
            return Content(JsonConvert.SerializeObject(list));
        }

        public ActionResult SeByyy()
        {
            String Id = Request["bid"];
            List<config_file_third_kindModel> list = isb.SeBy(Id);
            return Content(JsonConvert.SerializeObject(list));
        }

        public ActionResult SeByyyy()
        {
            String Id = Request["qid"];
            List<config_majorModel> list = iii.SeBy(Id);
            return Content(JsonConvert.SerializeObject(list));
        }

        public ActionResult Update(int id)
        {

            engage_major_releaseModel sd = new engage_major_releaseModel()
            {
                Id = short.Parse(id.ToString())
            };
            List<engage_major_releaseModel> list = re.SelectBy(sd);
            engage_major_releaseModel st = new engage_major_releaseModel()
            {
                Id = list[0].Id,
                first_kind_id=list[0].first_kind_id,
                first_kind_name = list[0].first_kind_name,
                second_kind_id = list[0].second_kind_id,
                second_kind_name = list[0].second_kind_name,
                third_kind_id = list[0].third_kind_id,
                third_kind_name = list[0].third_kind_name,
                major_kind_id = list[0].major_kind_id,
                major_kind_name = list[0].major_kind_name,
                major_id=list[0].major_id,
                major_name = list[0].major_name,
                human_amount = list[0].human_amount,
                engage_type = list[0].engage_type,
                deadline= list[0].deadline,
                changer = list[0].changer,
                change_time = list[0].change_time,
                major_describe = list[0].major_describe,
                engage_required = list[0].engage_required,
                register = list[0].register,
                regist_time = list[0].regist_time,
            };
            return View(st);
        }
        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Update(engage_major_releaseModel u)
        {

            // TODO: Add update logic here
            if (re.Update(u) > 0)
            {
                return JavaScript("alert('修改成功');window.location.href='/engage_major_release/Index'");
            }
            else
            {

                ViewBag.dt = u;
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            engage_major_releaseModel st = new engage_major_releaseModel()
            {
                Id = short.Parse(id.ToString())
            };
            if (re.Del(st) > 0)
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