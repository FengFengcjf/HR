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
    public class engage_interviewDAO:DaoBase<engage_interview>,Iengage_interviewDAO
    {
          public List<engage_interviewModel> SelectBy(engage_interviewModel st)
        {
            List<engage_interview> list = SelectBy(e => e.Id.Equals(st.Id));
            List<engage_interviewModel> list2 = new List<engage_interviewModel>();
            foreach (var item in list)
            {
               engage_interviewModel sd = new engage_interviewModel()
                {
                    Id =item.Id
                };
                list2.Add(sd);
            }
            return list2;
        }

        public int Add(engage_interviewModel st)
        {
            //把DTO转为EO
            engage_interview est = new engage_interview()
            {
                Id = st.Id,
                resume_id=st.resume_id,
                human_major_id =st.human_major_id,
                human_major_kind_id=st.human_major_kind_id,
                human_name=st.human_name,
                human_major_name=st.human_major_name,
                human_major_kind_name=st.human_major_kind_name,
                interview_amount = st.interview_amount,
                interview_status=st.interview_status
            };
            return Add(est);
        }

        public int Del(Model.engage_interviewModel st)
        {
            engage_interview est = new engage_interview()
            {
                Id = st.Id

            };
            return Delete(est);
        }

        public List<Model.engage_interviewModel> Select()
        {
            List<engage_interview> list = SelectAll();
            List<engage_interviewModel> list2 = new List<engage_interviewModel>();
            foreach (engage_interview item in list)
            {
                engage_interviewModel sm = new engage_interviewModel()
                {
                    Id = item.Id,
                    interview_amount=item.interview_amount
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int Update(engage_interviewModel st)
        {
            engage_interview est = new engage_interview()
            {
                Id = st.Id,
                image_degree = st.image_degree,
                native_language_degree = st.native_language_degree,
                foreign_language_degree = st.foreign_language_degree,
                response_speed_degree = st.response_speed_degree,
                EQ_degree = st.EQ_degree,
                IQ_degree = st.IQ_degree,
                multi_quality_degree = st.multi_quality_degree,
                register = st.register,
                registe_time = st.registe_time,
                interview_comment = st.interview_comment,
                interview_status = "待筛选",
                resume_id=st.resume_id,
                human_name=st.human_name,
                interview_amount=st.interview_amount,
                human_major_id=st.human_major_id,
                human_major_kind_id=st.human_major_kind_id,
                human_major_kind_name=st.human_major_kind_name,
                human_major_name=st.human_major_name,
            };
            return Update(est);
        }

        public List<engage_interviewModel> SelectBy2(String ii)
        {
            List<engage_interview> list = SelectBy(e => e.resume_id.Equals(ii));
            List<engage_interviewModel> list2 = new List<engage_interviewModel>();
            foreach (var item in list)
            {
                engage_interviewModel sd = new engage_interviewModel()
                {
                    Id = item.Id,
                    human_name = item.human_name,
                    human_major_kind_id = item.human_major_kind_id,
                    human_major_kind_name = item.human_major_kind_name,
                    human_major_id = item.human_major_id,
                    human_major_name = item.human_major_name,
                    check_time = item.check_time,
                    interview_status = item.interview_status,
                    interview_amount = item.interview_amount,
                    image_degree = item.image_degree,
                    native_language_degree = item.native_language_degree,
                    foreign_language_degree = item.foreign_language_degree,
                    response_speed_degree = item.response_speed_degree,
                    EQ_degree = item.EQ_degree,
                    multi_quality_degree = item.multi_quality_degree,
                    IQ_degree = item.IQ_degree,
                    register = item.register,
                    checker = item.checker,
                    registe_time = item.registe_time,
                    resume_id = item.resume_id,
                    result = item.result,
                    interview_comment = item.interview_comment,
                };
                list2.Add(sd);
            }
            return list2;
        }

        public List<engage_interviewModel> Fenye2(int dqy)
        {
            int rows = 0;
            List<engage_interview> list = FenYe<int>(e => e.Id, e => e.interview_status.Equals("待筛选"), ref rows, dqy, 3);
            List<engage_interviewModel> list2 = new List<engage_interviewModel>();
            foreach (engage_interview item in list)
            {
                engage_interviewModel um = new engage_interviewModel()
                {
                    Id = item.Id,
                    human_name = item.human_name,                   
                    human_major_kind_id = item.human_major_kind_id,
                    human_major_kind_name = item.human_major_kind_name,
                    human_major_id = item.human_major_id,
                    human_major_name = item.human_major_name,                  
                    check_time = item.check_time,
                    interview_status = item.interview_status,
                    interview_amount=item.interview_amount,
                    image_degree = item.image_degree,
                    native_language_degree = item.native_language_degree,
                    foreign_language_degree = item.foreign_language_degree,
                    response_speed_degree = item.response_speed_degree,
                    EQ_degree = item.EQ_degree,
                    multi_quality_degree = item.multi_quality_degree,
                    IQ_degree = item.IQ_degree,
                    register = item.register,
                    checker = item.checker,
                    registe_time = item.registe_time,
                    resume_id = item.resume_id,
                    result = item.result,
                    interview_comment = item.interview_comment,
                };
                list2.Add(um);
            }
            return list2;
        }

        public int Row()
        {
            int rows = 0;
            List<engage_interview> list = FenYe<int>(e => e.Id, e => e.Id > 0, ref rows, 1, 3);
            return rows;
        }


        public int Pages()
        {
            int rows = 0;
            List<engage_interview> list = FenYe<int>(e => e.Id, e => e.Id > 0, ref rows, 1, 3);
            double page = rows / 3.00;
            return int.Parse(Math.Ceiling(page).ToString());
        }

    }
}
