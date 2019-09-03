using EFentity;
using IntDAO;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class engage_resumeDAO:DaoBase<engage_resume>,Iengage_resumeDAO
    {
          public List<engage_resumeModel> SelectBy(engage_resumeModel st)
        {
            List<engage_resume> list = SelectBy(e => e.Id.Equals(st.Id));
            List<engage_resumeModel> list2 = new List<engage_resumeModel>();
            foreach (var item in list)
            {
               engage_resumeModel sd = new engage_resumeModel()
                {
                   Id = item.Id,
                   human_name = item.human_name,
                   engage_type = item.engage_type,
                   human_address = item.human_address,
                   human_postcode = item.human_postcode,
                   human_major_kind_id = item.human_major_kind_id,
                   human_major_kind_name = item.human_major_kind_name,
                   human_major_id = item.human_major_id,
                   human_major_name = item.human_major_name,
                   human_telephone = item.human_telephone,
                   human_homephone = item.human_homephone,
                   human_mobilephone = item.human_mobilephone,
                   human_email = item.human_email,
                   human_hobby = item.human_hobby,
                   human_specility = item.human_specility,
                   human_sex = item.human_sex,
                   human_religion = item.human_religion,
                   human_party = item.human_party,
                   human_nationality = item.human_nationality,
                   human_race = item.human_race,
                   human_birthday = item.human_birthday,
                   human_age = item.human_age,
                   human_educated_degree = item.human_educated_degree,
                   human_educated_years = item.human_educated_years,
                   human_educated_major = item.human_educated_major,
                   human_college = item.human_college,
                   human_idcard = item.human_idcard,
                   human_birthplace = item.human_birthplace,
                   demand_salary_standard = item.demand_salary_standard,
                   human_history_records = item.human_history_records,
                   remark = item.remark,
                   regist_time = item.regist_time,
                   check_time = item.check_time,
                   pass_check_time = item.pass_check_time,
                   pass_regist_time = item.pass_regist_time,
                   test_check_time = item.test_check_time,
                   recomandation = item.recomandation,
                   checker=item.checker,
                   interview_status = item.interview_status

               };
                list2.Add(sd);
            }
            return list2;
        }

        public int Add(engage_resumeModel st)
        {
            //把DTO转为EO
            engage_resume est = new engage_resume()
            {
                Id = st.Id,
                human_name=st.human_name,
                engage_type = st.engage_type,
                human_address = st.human_address,
                human_postcode = st.human_postcode,
                human_major_kind_id = st.human_major_kind_id,
                human_major_kind_name = st.human_major_kind_name,
                human_major_id = st.human_major_id,
                human_major_name = st.human_major_name,
                human_telephone = st.human_telephone,
                human_homephone = st.human_homephone,
                human_mobilephone = st.human_mobilephone,
                human_email = st.human_email,
                human_hobby = st.human_hobby,
                human_specility = st.human_specility,
                human_sex = st.human_sex,
                human_religion = st.human_religion,
                human_party = st.human_party,
                human_nationality = st.human_nationality,
                human_race = st.human_race,
                human_birthday = st.human_birthday,
                human_age = st.human_age,
                human_educated_degree = st.human_educated_degree,
                human_educated_years = st.human_educated_years,
                human_educated_major = st.human_educated_major,
                human_college = st.human_college,
                human_idcard = st.human_idcard,
                human_birthplace = st.human_birthplace,
                demand_salary_standard = st.demand_salary_standard,
                human_history_records = st.human_history_records,
                remark = st.remark,
                regist_time=st.regist_time,
                check_time = st.check_time,
                pass_check_time = st.pass_check_time,
                pass_regist_time = st.pass_regist_time,
                test_check_time = st.test_check_time,
                check_status= "待复核"
            };
            return Add(est);
        }

        public int Del(Model.engage_resumeModel st)
        {
            engage_resume est = new engage_resume()
            {
                Id = st.Id,


            };
            return Delete(est);
        }

        public List<Model.engage_resumeModel> Select()
        {
            List<engage_resume> list = SelectAll();
            List<engage_resumeModel> list2 = new List<engage_resumeModel>();
            foreach (engage_resume item in list)
            {
                engage_resumeModel sm = new engage_resumeModel()
                {
                    Id = item.Id
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int Update(engage_resumeModel st)
        {
            engage_resume est = new engage_resume()
            {
                Id = st.Id,
                human_name = st.human_name,
                engage_type = st.engage_type,
                human_address = st.human_address,
                human_postcode = st.human_postcode,
                human_major_kind_id = st.human_major_kind_id,
                human_major_kind_name = st.human_major_kind_name,
                human_major_id = st.human_major_id,
                human_major_name = st.human_major_name,
                human_telephone = st.human_telephone,
                human_homephone = st.human_homephone,
                human_mobilephone = st.human_mobilephone,
                human_email = st.human_email,
                human_hobby = st.human_hobby,
                human_specility = st.human_specility,
                human_sex = st.human_sex,
                human_religion = st.human_religion,
                human_party = st.human_party,
                human_nationality = st.human_nationality,
                human_race = st.human_race,
                human_birthday = st.human_birthday,
                human_age = st.human_age,
                human_educated_degree = st.human_educated_degree,
                human_educated_years = st.human_educated_years,
                human_educated_major = st.human_educated_major,
                human_college = st.human_college,
                human_idcard = st.human_idcard,
                human_birthplace = st.human_birthplace,
                demand_salary_standard = st.demand_salary_standard,
                human_history_records = st.human_history_records,
                remark = st.remark,
                regist_time = st.regist_time,
                check_time = st.check_time,
                pass_check_time = st.pass_check_time,
                pass_regist_time = st.pass_regist_time,
                test_check_time = st.test_check_time,
                register = st.register,
                checker = st.checker,
                check_status = "通过",
                interview_status = "待面试",
                recomandation =st.recomandation
            };
            return Update(est);
        }
        public List<engage_resumeModel> SeBy(int dqy ,String Qid, String Pid, String Guan, String Start, String End,String Zt)
        {
            int rows = 0;
            List<engage_resume> list;
            if (Start == "" && End == "")
            {
                list = FenYe(e => e.Id,e => e.human_major_kind_id.Contains(Qid)&&e.check_status.Equals(Zt) && e.human_major_id.Contains(Pid) && (e.human_name.Contains(Guan) || e.human_telephone.Contains(Guan) || e.human_idcard.Contains(Guan) || e.human_history_records.Contains(Guan)), ref rows, dqy, 3);
            }
            else
            {
                DateTime start = Convert.ToDateTime(Start);
                DateTime end = Convert.ToDateTime(End);
                list = FenYe(e => e.Id, e => e.human_major_kind_id.Contains(Qid) && e.human_major_id.Contains(Pid) && (e.human_name.Contains(Guan) || e.human_telephone.Contains(Guan) || e.human_idcard.Contains(Guan) || e.human_history_records.Contains(Guan)) && e.regist_time >= start && e.regist_time <= end, ref rows, dqy, 3);
            }
                List<engage_resumeModel> list2 = new List<engage_resumeModel>();
            foreach (var item in list)
            {
                engage_resumeModel sd = new engage_resumeModel()
                {
                    Id = item.Id,
                    human_major_kind_id=item.human_major_kind_id,
                    human_major_id =item.human_major_id,
                    human_name = item.human_name,
                    human_sex = item.human_sex,
                    human_major_kind_name = item.human_major_kind_name,
                    human_major_name = item.human_major_name,
                    human_telephone = item.human_telephone,
                    check_status = item.check_status,
                };
                list2.Add(sd);
            }
            return list2;
        }

        public List<engage_resumeModel> SeByy(int dqy, String Qid, String Pid, String Guan, String Start, String End, String Zt)
        {
            int rows = 0;
            List<engage_resume> list;
            if (Start == "" && End == "")
            {
                list = FenYe(e => e.Id, e => e.human_major_kind_id.Contains(Qid) && e.check_status.Equals(Zt) && e.human_major_id.Contains(Pid) && (e.human_name.Contains(Guan) || e.human_telephone.Contains(Guan) || e.human_idcard.Contains(Guan) || e.human_history_records.Contains(Guan)), ref rows, dqy, 3);
            }
            else
            {
                DateTime start = Convert.ToDateTime(Start);
                DateTime end = Convert.ToDateTime(End);
                list = FenYe(e => e.Id, e => e.human_major_kind_id.Contains(Qid) && e.human_major_id.Contains(Pid) && (e.human_name.Contains(Guan) || e.human_telephone.Contains(Guan) || e.human_idcard.Contains(Guan) || e.human_history_records.Contains(Guan)) && e.regist_time >= start && e.regist_time <= end, ref rows, dqy, 3);
            }
            List<engage_resumeModel> list2 = new List<engage_resumeModel>();
            foreach (var item in list)
            {
                engage_resumeModel sd = new engage_resumeModel()
                {
                    Id = item.Id,
                    human_major_kind_id = item.human_major_kind_id,
                    human_major_id = item.human_major_id,
                    human_name = item.human_name,
                    human_sex = item.human_sex,
                    human_major_kind_name = item.human_major_kind_name,
                    human_major_name = item.human_major_name,
                    human_telephone = item.human_telephone,
                    check_status = item.check_status,
                    interview_status=item.interview_status
                };
                list2.Add(sd);
            }
            return list2;
        }

        public List<engage_resumeModel> Fenye(int dqy)
        {
            int rows = 0;
            List<engage_resume> list = FenYe<int>(e => e.Id, e => e.Id > 0, ref rows, dqy, 3);
            List<engage_resumeModel> list2 = new List<engage_resumeModel>();
            foreach (engage_resume item in list)
            {
                engage_resumeModel um = new engage_resumeModel()
                {
                    Id = item.Id,
                    human_name = item.human_name,
                    engage_type = item.engage_type,
                    human_address = item.human_address,
                    human_postcode = item.human_postcode,
                    human_major_kind_id = item.human_major_kind_id,
                    human_major_kind_name = item.human_major_kind_name,
                    human_major_id = item.human_major_id,
                    human_major_name = item.human_major_name,
                    human_telephone = item.human_telephone,
                    human_homephone = item.human_homephone,
                    human_mobilephone = item.human_mobilephone,
                    human_email = item.human_email,
                    human_hobby = item.human_hobby,
                    human_specility = item.human_specility,
                    human_sex = item.human_sex,
                    human_religion = item.human_religion,
                    human_party = item.human_party,
                    human_nationality = item.human_nationality,
                    human_race = item.human_race,
                    human_birthday = item.human_birthday,
                    human_age = item.human_age,
                    human_educated_degree = item.human_educated_degree,
                    human_educated_years = item.human_educated_years,
                    human_educated_major = item.human_educated_major,
                    human_college = item.human_college,
                    human_idcard = item.human_idcard,
                    human_birthplace = item.human_birthplace,
                    demand_salary_standard = item.demand_salary_standard,
                    human_history_records = item.human_history_records,
                    remark = item.remark,
                    regist_time = item.regist_time,
                    check_time = item.check_time,
                    pass_check_time = item.pass_check_time,
                    pass_regist_time = item.pass_regist_time,
                    test_check_time = item.test_check_time,
                };
                list2.Add(um);
            }
            return list2;
        }

        public int Row()
        {
            int rows = 0;
            List<engage_resume> list = FenYe<int>(e => e.Id, e => e.Id > 0, ref rows, 1, 3);
            return rows;
        }


        public int Pages()
        {
            int rows = 0;
            List<engage_resume> list = FenYe<int>(e => e.Id, e => e.Id > 0, ref rows, 1, 3);
            double page = rows / 3.00;
            return int.Parse(Math.Ceiling(page).ToString());
        }
    }
}
