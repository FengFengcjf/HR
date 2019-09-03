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
    public class engage_resumeController : Controller
    {
        Iengage_major_releaseBLL sb = IocCreate.Createengage_major_releaseBLL();
        Iengage_resumeBLL ss = IocCreate.Createengage_resumeBLL();
        Iconfig_major_kindBLL re = IocCreate.Createconfig_major_kindBLL();
        Ihuman_fileBLL rr = IocCreate.Createhuman_fileBLL();

        // GET: engage_resume
        public ActionResult Index()
        {
            ViewData["rows"] = rr.Row();
            ViewData["page"] = rr.Pages();
            return View();
        }



        public ActionResult Index2()
        {
            int dqy = 1;
            String Qid = Session["Qid"].ToString();
            String Pid = Session["Pid"].ToString();
            String Guan = Session["Guan"].ToString();
            String Start = Session["Start"].ToString();
            String End = Session["End"].ToString();
            String Zt = "通过";
            if (Qid == "null")
            {
                Qid = "";
            }
            if (Pid == "null")
            {
                Pid = "";
            }
            List<engage_resumeModel> list = ss.SeBy(dqy,Qid, Pid,Guan,Start,End,Zt);
            return Content(JsonConvert.SerializeObject(list));
        }

        public ActionResult Index3()
        {
            ViewData["rows"] = rr.Row();
            ViewData["page"] = rr.Pages();
            return View();
        }



        public ActionResult Index4()
        {
            int dqy = 1;
            String Qid = Session["Qid"].ToString();
            String Pid = Session["Pid"].ToString();
            String Guan = Session["Guan"].ToString();
            String Start = Session["Start"].ToString();
            String End = Session["End"].ToString();
            String Zt = "通过";
            if (Qid == "null")
            {
                Qid = "";
            }
            if (Pid == "null")
            {
                Pid = "";
            }
            List<engage_resumeModel> list = ss.SeByy(dqy, Qid, Pid, Guan, Start, End, Zt);
            return Content(JsonConvert.SerializeObject(list));
        }

        public ActionResult Add(int id)
        {
            engage_major_releaseModel sd = new engage_major_releaseModel()
            {
                Id = short.Parse(id.ToString())
            };
            List<engage_major_releaseModel> list = sb.SelectBy(sd);
            List<SelectListItem> listyj = new List<SelectListItem>();
            SelectListItem sl = new SelectListItem()
               {
                    Text = list[0].major_kind_name.ToString(),
                    Value = list[0].major_kind_id.ToString()
               };
               listyj.Add(sl);

            List<SelectListItem> listy = new List<SelectListItem>();
            SelectListItem si = new SelectListItem()
            {
                Text = list[0].major_name.ToString(),
                Value = list[0].major_id.ToString()
            };
            listy.Add(si);

            List<SelectListItem> lista = new List<SelectListItem>();
            SelectListItem sa = new SelectListItem()
            {
                Text = list[0].engage_type.ToString(),
                Value = list[0].engage_type.ToString()
            };
            lista.Add(sa);
            engage_resumeModel ctm = new engage_resumeModel();
            ViewData["yj"] = listyj;
            ViewData["jj"] = listy;
            ViewData["ej"] = lista;
            return View(ctm);
        }


        [HttpPost]
        public ActionResult Add(engage_resumeModel s)
        {

            engage_major_releaseModel csm = new engage_major_releaseModel
            {
                major_kind_id = s.human_major_kind_id
            };
            engage_major_releaseModel cfm = new engage_major_releaseModel
            {
                major_id = s.human_major_id
            };
            List<engage_major_releaseModel> lists = sb.SelectByName(csm);
            List<engage_major_releaseModel> listf = sb.SelectByNamee(cfm);

            s.human_major_kind_name = lists[0].major_kind_name;
            s.human_major_name = listf[0].major_name;
            s.check_time = DateTime.Now;
            s.test_check_time = DateTime.Now;
            s.pass_regist_time = DateTime.Now;
            s.pass_check_time = DateTime.Now;

            human_fileModel css = new human_fileModel
            {
                human_name = s.human_name,
                human_address = s.human_address,
                human_postcode = s.human_postcode,
                human_major_kind_id = s.human_major_kind_id,
                human_major_kind_name = s.human_major_kind_name,
                human_major_id = s.human_major_id,
                hunma_major_name = s.human_major_name,
                human_telephone = s.human_telephone,
                human_mobilephone = s.human_mobilephone,
                human_email = s.human_email,
                human_hobby = s.human_hobby,
                human_speciality = s.human_specility,
                human_sex = s.human_sex,
                human_religion = s.human_religion,
                human_party = s.human_party,
                human_nationality = s.human_nationality,
                human_race = s.human_race,
                human_birthday = s.human_birthday,
                human_age = s.human_age,
                human_birthplace = s.human_birthplace,
                human_educated_degree = s.human_educated_degree,
                human_educated_years = s.human_educated_years,
                human_educated_major = s.human_educated_major,
                human_id_card = s.human_idcard,
                remark = s.remark,
                regist_time = DateTime.Now,
                check_time = DateTime.Now,
                change_time = DateTime.Now,
                lastly_change_time = DateTime.Now,
                delete_time = DateTime.Now,
                recovery_time = DateTime.Now,
                check_status = "待复核"
            };

            if (ss.Add(s) > 0 && rr.Add(css)>0)
            {
                return Content("<script>alert('新增成功');window.location='Add2'</script>");
            }
            else
            {
                return Content("<script>alert('新增成功');window.location='Add2'</script>");
            }
        }


        public ActionResult Add2()
        {
            List<config_major_kindModel> lll = re.Select();
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
            engage_resumeModel ctm = new engage_resumeModel();
            ViewData["jj"] = liss;
            return View(ctm);
        }

        [HttpPost]
        public ActionResult Add2(engage_resumeModel s)
        {

            engage_major_releaseModel csm = new engage_major_releaseModel
            {
                major_kind_id = s.human_major_kind_id
            };
            engage_major_releaseModel cfm = new engage_major_releaseModel
            {
                major_id = s.human_major_id
            };
            List<engage_major_releaseModel> lists = sb.SelectByName(csm);
            List<engage_major_releaseModel> listf = sb.SelectByNamee(cfm);

            s.human_major_kind_name = lists[0].major_kind_name;
            s.human_major_name = listf[0].major_name;
            s.check_time = DateTime.Now;
            s.test_check_time = DateTime.Now;
            s.pass_regist_time = DateTime.Now;
            s.pass_check_time = DateTime.Now;

            human_fileModel css = new human_fileModel
            {
                human_name = s.human_name,
                human_address = s.human_address,
                human_postcode = s.human_postcode,
                human_major_kind_id = s.human_major_kind_id,
                human_major_kind_name = s.human_major_kind_name,
                human_major_id = s.human_major_id,
                hunma_major_name = s.human_major_name,
                human_telephone = s.human_telephone,
                human_mobilephone = s.human_mobilephone,
                human_email = s.human_email,
                human_hobby = s.human_hobby,
                human_speciality = s.human_specility,
                human_sex = s.human_sex,
                human_religion = s.human_religion,
                human_party = s.human_party,
                human_nationality = s.human_nationality,
                human_race = s.human_race,
                human_birthday = s.human_birthday,
                human_age = s.human_age,
                human_birthplace = s.human_birthplace,
                human_educated_degree = s.human_educated_degree,
                human_educated_years = s.human_educated_years,
                human_educated_major = s.human_educated_major,
                human_id_card = s.human_idcard,
                remark = s.remark,
                regist_time = DateTime.Now,
                check_time = DateTime.Now,
                change_time = DateTime.Now,
                lastly_change_time = DateTime.Now,
                delete_time = DateTime.Now,
                recovery_time = DateTime.Now,
                check_status = "待复核"
            };

            if (ss.Add(s) > 0 && rr.Add(css) > 0)
            {
                return Content("<script>alert('新增成功');window.location='Add2'</script>");
            }
            else
            {
                return Content("<script>alert('新增成功');window.location='Add2'</script>");
            }
        }



        [HttpGet]
        public ActionResult SelectBy()
        {
            return View();
        }

        public ActionResult SelectBy2()
        {
            List<config_major_kindModel> list = re.Select();
            return Content(JsonConvert.SerializeObject(list));
        }

        public ActionResult SelectBy3()
        {
            Session["Qid"] = Request["qid"];
            Session["Pid"] = Request["pid"];
            Session["Guan"] = Request["guan"];
            Session["Start"] = Request["start"];
            Session["End"] = Request["end"];
            return JavaScript("alert('查询成功');window.location.href='Index'");
        }

        [HttpGet]
        public ActionResult SelectByy()
        {
            return View();
        }

        public ActionResult SelectByy2()
        {
            Session["Qid"] = Request["qid"];
            Session["Pid"] = Request["pid"];
            Session["Guan"] = Request["guan"];
            Session["Start"] = Request["start"];
            Session["End"] = Request["end"];
            return JavaScript("alert('查询成功');window.location.href='Index3'");
        }

        public ActionResult Update(int id)
        {

            engage_resumeModel sd = new engage_resumeModel()
            {
                Id = short.Parse(id.ToString())
            };
            List<engage_resumeModel> list = ss.SelectBy(sd);
            List<SelectListItem> listyj = new List<SelectListItem>();
            SelectListItem sl = new SelectListItem()
            {
                Text = list[0].human_major_kind_name.ToString(),
                Value = list[0].human_major_kind_id.ToString()
            };
            listyj.Add(sl);

            List<SelectListItem> listy = new List<SelectListItem>();
            SelectListItem si = new SelectListItem()
            {
                Text = list[0].human_major_name.ToString(),
                Value = list[0].human_major_id.ToString()
            };
            listy.Add(si);

            List<SelectListItem> lista = new List<SelectListItem>();
            SelectListItem sa = new SelectListItem()
            {
                Text = list[0].engage_type.ToString(),
                Value = list[0].engage_type.ToString()
            };
            lista.Add(sa);
            engage_resumeModel ctm = new engage_resumeModel();
            ViewData["yj"] = listyj;
            ViewData["jj"] = listy;
            ViewData["ej"] = lista;

            engage_resumeModel st = new engage_resumeModel()
            {
                Id = list[0].Id,
                human_name = list[0].human_name,
                engage_type = list[0].engage_type,
                human_address = list[0].human_address,
                human_postcode = list[0].human_postcode,
                human_major_kind_id = list[0].human_major_kind_id,
                human_major_kind_name = list[0].human_major_kind_name,
                human_major_id = list[0].human_major_id,
                human_major_name = list[0].human_major_name,
                human_telephone = list[0].human_telephone,
                human_homephone = list[0].human_homephone,
                human_mobilephone = list[0].human_mobilephone,
                human_email = list[0].human_email,
                human_hobby = list[0].human_hobby,
                human_specility = list[0].human_specility,
                human_sex = list[0].human_sex,
                human_religion = list[0].human_religion,
                human_party = list[0].human_party,
                human_nationality = list[0].human_nationality,
                human_race = list[0].human_race,
                human_birthday = list[0].human_birthday,
                human_age = list[0].human_age,
                human_educated_degree = list[0].human_educated_degree,
                human_educated_years = list[0].human_educated_years,
                human_educated_major = list[0].human_educated_major,
                human_college = list[0].human_college,
                human_idcard = list[0].human_idcard,
                human_birthplace = list[0].human_birthplace,
                demand_salary_standard = list[0].demand_salary_standard,
                human_history_records = list[0].human_history_records,
                remark = list[0].remark,
                regist_time = list[0].regist_time,
                check_time = list[0].check_time,
                pass_check_time = list[0].pass_check_time,
                pass_regist_time = list[0].pass_regist_time,
                test_check_time = list[0].test_check_time,
                recomandation = list[0].recomandation,
                checker = list[0].checker,

            };
            return View(st);
        }
        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Update(engage_resumeModel u)
        {

            // TODO: Add update logic here
            if (ss.Update(u) > 0)
            {
                return JavaScript("alert('推荐成功');window.location.href='/engage_resume/SelectBy'");
            }
            else
            {

                ViewBag.dt = u;
            }
            return View();
        }

        public ActionResult Update2(int id)
        {

            engage_resumeModel sd = new engage_resumeModel()
            {
                Id = short.Parse(id.ToString())
            };
            List<engage_resumeModel> list = ss.SelectBy(sd);
            List<SelectListItem> listyj = new List<SelectListItem>();
            SelectListItem sl = new SelectListItem()
            {
                Text = list[0].human_major_kind_name.ToString(),
                Value = list[0].human_major_kind_id.ToString()
            };
            listyj.Add(sl);

            List<SelectListItem> listy = new List<SelectListItem>();
            SelectListItem si = new SelectListItem()
            {
                Text = list[0].human_major_name.ToString(),
                Value = list[0].human_major_id.ToString()
            };
            listy.Add(si);

            List<SelectListItem> lista = new List<SelectListItem>();
            SelectListItem sa = new SelectListItem()
            {
                Text = list[0].engage_type.ToString(),
                Value = list[0].engage_type.ToString()
            };
            lista.Add(sa);
            engage_resumeModel ctm = new engage_resumeModel();
            ViewData["yj"] = listyj;
            ViewData["jj"] = listy;
            ViewData["ej"] = lista;

            engage_resumeModel st = new engage_resumeModel()
            {
                Id = list[0].Id,
                human_name = list[0].human_name,
                engage_type = list[0].engage_type,
                human_address = list[0].human_address,
                human_postcode = list[0].human_postcode,
                human_major_kind_id = list[0].human_major_kind_id,
                human_major_kind_name = list[0].human_major_kind_name,
                human_major_id = list[0].human_major_id,
                human_major_name = list[0].human_major_name,
                human_telephone = list[0].human_telephone,
                human_homephone = list[0].human_homephone,
                human_mobilephone = list[0].human_mobilephone,
                human_email = list[0].human_email,
                human_hobby = list[0].human_hobby,
                human_specility = list[0].human_specility,
                human_sex = list[0].human_sex,
                human_religion = list[0].human_religion,
                human_party = list[0].human_party,
                human_nationality = list[0].human_nationality,
                human_race = list[0].human_race,
                human_birthday = list[0].human_birthday,
                human_age = list[0].human_age,
                human_educated_degree = list[0].human_educated_degree,
                human_educated_years = list[0].human_educated_years,
                human_educated_major = list[0].human_educated_major,
                human_college = list[0].human_college,
                human_idcard = list[0].human_idcard,
                human_birthplace = list[0].human_birthplace,
                demand_salary_standard = list[0].demand_salary_standard,
                human_history_records = list[0].human_history_records,
                remark = list[0].remark,
                regist_time = list[0].regist_time,
                check_time = list[0].check_time,
                pass_check_time = list[0].pass_check_time,
                pass_regist_time = list[0].pass_regist_time,
                test_check_time = list[0].test_check_time,
                recomandation = list[0].recomandation,
                checker = list[0].checker,

            };
            return View(st);
        }
        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Update2(engage_resumeModel u)
        {

            // TODO: Add update logic here
            if (ss.Update(u) > 0)
            {
                return JavaScript("alert('推荐成功');window.location.href='/engage_resume/SelectBy'");
            }
            else
            {

                ViewBag.dt = u;
            }
            return View();
        }

    }
}
