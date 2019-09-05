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
    public class engage_interviewController : Controller
    {
        Iengage_resumeBLL ss = IocCreate.Createengage_resumeBLL();
        Iengage_interviewBLL ie = IocCreate.Createengage_interviewBLL();
        public ActionResult Index()
        {
            ViewData["rows"] = ss.Row();
            ViewData["page"] = ss.Pages();
            return View();
        }

        public ActionResult Index2()
        {
            IsoDateTimeConverter timeConverter = new IsoDateTimeConverter { DateTimeFormat = "yyyy'-'MM'-'dd HH':'mm':'ss" };
            List<engage_resumeModel> list = ss.Fenye2(int.Parse(Request["dqy"]));
            return Content(JsonConvert.SerializeObject(list, Formatting.Indented, timeConverter));
        }

        public ActionResult Index3()
        {
            String ii = Session["ii"].ToString();
            List<engage_interviewModel> list = ie.SelectBy2(ii);
            return Content(JsonConvert.SerializeObject(list));
        }

        public ActionResult Index4()
        {
            ViewData["rows"] = ss.Row();
            ViewData["page"] = ss.Pages();
            return View();
        }

        public ActionResult Index5()
        {
            IsoDateTimeConverter timeConverter = new IsoDateTimeConverter { DateTimeFormat = "yyyy'-'MM'-'dd HH':'mm':'ss" };
            List<engage_interviewModel> list = ie.Fenye2(int.Parse(Request["dqy"]));
            return Content(JsonConvert.SerializeObject(list, Formatting.Indented, timeConverter));
        }

        public ActionResult Index6()
        {
            String kk = Session["kk"].ToString();
            IsoDateTimeConverter timeConverter = new IsoDateTimeConverter { DateTimeFormat = "yyyy'-'MM'-'dd HH':'mm':'ss" };
            List<engage_interviewModel> list = ie.SelectBy2(kk);
            return Content(JsonConvert.SerializeObject(list, Formatting.Indented, timeConverter));
        }


        public ActionResult Update(int id) 
        {
            Session["ii"] = id;
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
                register = list[0].register,
            };
            
            return View(st);
        }
        [HttpPost]
        public ActionResult Update(engage_resumeModel u)
        {
            String ii = Session["ii"].ToString();
            List<engage_interviewModel> list = ie.SelectBy2(ii);
            short id = list[0].Id;
            String resumeid = list[0].resume_id;
            short interviewamount = list[0].interview_amount;

            String image_degree = Request["image_degree"];
            String native_language_degree = Request["native_language_degree"];
            String foreign_language_degree = Request["foreign_language_degree"];
            String response_speed_degree = Request["response_speed_degree"];
            String EQ_degree = Request["EQ_degree"];
            String IQ_degree = Request["IQ_degree"];
            String multi_quality_degree = Request["multi_quality_degree"];
            String register = Request["register"]; 
            DateTime registe_time = Convert.ToDateTime(Request["registe_time"]);
            String interview_comment = Request["interview_comment"];

            engage_interviewModel css = new engage_interviewModel
            {
                Id=id,
                image_degree = image_degree,
                native_language_degree = native_language_degree,
                foreign_language_degree = foreign_language_degree,
                response_speed_degree = response_speed_degree,
                EQ_degree = EQ_degree,
                IQ_degree = IQ_degree,
                multi_quality_degree = multi_quality_degree,
                register = register,
                registe_time = registe_time,
                interview_comment = interview_comment,
                interview_status= "待筛选",
                resume_id=resumeid,
                human_name=u.human_name,
                human_major_id=u.human_major_id,
                human_major_kind_id=u.human_major_kind_id,
                human_major_kind_name=u.human_major_kind_name,
                human_major_name=u.human_major_name,
                interview_amount= interviewamount
            };
            engage_resumeModel ccc = new engage_resumeModel
            {
                Id = u.Id,
                interview_status = "待筛选",
                human_name = u.human_name,
                engage_type = u.engage_type,
                human_address = u.human_address,
                human_postcode = u.human_postcode,
                human_major_kind_id = u.human_major_kind_id,
                human_major_kind_name = u.human_major_kind_name,
                human_major_id = u.human_major_id,
                human_major_name = u.human_major_name,
                human_telephone = u.human_telephone,
                human_homephone = u.human_homephone,
                human_mobilephone = u.human_mobilephone,
                human_email = u.human_email,
                human_hobby = u.human_hobby,
                human_specility = u.human_specility,
                human_sex = u.human_sex,
                human_religion = u.human_religion,
                human_party = u.human_party,
                human_nationality = u.human_nationality,
                human_race = u.human_race,
                human_birthday = u.human_birthday,
                human_age = u.human_age,
                human_educated_degree = u.human_educated_degree,
                human_educated_years = u.human_educated_years,
                human_educated_major = u.human_educated_major,
                human_college = u.human_college,
                human_idcard = u.human_idcard,
                human_birthplace = u.human_birthplace,
                demand_salary_standard = u.demand_salary_standard,
                human_history_records = u.human_history_records,
                remark = u.remark,
                regist_time = u.regist_time,
                check_time = u.check_time,
                pass_check_time = u.pass_check_time,
                pass_regist_time = u.pass_regist_time,
                test_check_time = u.test_check_time,
                recomandation = u.recomandation,
                checker = u.checker,
                register = u.register,
            };

            if (ie.Update(css) > 0 && ss.Update(ccc)>0)
            {
                return JavaScript("alert('登记成功');window.location.href='/engage_interview/Index'");
            }
            else
            {

                ViewBag.dt = u;
            }
            return View();
        }

        public ActionResult Update2(int id)
        {
            Session["kk"] = id;
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
                register = list[0].register,
            };

            return View(st);
        }
    }
}
