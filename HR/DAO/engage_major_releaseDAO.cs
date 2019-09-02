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
    public class engage_major_releaseDAO:DaoBase<engage_major_release>,Iengage_major_releaseDAO
    {
          public List<engage_major_releaseModel> SelectBy(engage_major_releaseModel st)
        {
            List<engage_major_release> list = SelectBy(e => e.Id.Equals(st.Id));
            List<engage_major_releaseModel> list2 = new List<engage_major_releaseModel>();
            foreach (var item in list)
            {
               engage_major_releaseModel sd = new engage_major_releaseModel()
                {
                   Id = item.Id,
                   first_kind_id=item.first_kind_id,
                   first_kind_name = item.first_kind_name,
                   second_kind_id=item.second_kind_id,
                   second_kind_name = item.second_kind_name,
                   third_kind_id=item.third_kind_id,
                   third_kind_name = item.third_kind_name,
                   major_kind_id=item.major_kind_id,
                   major_kind_name = item.major_kind_name,
                   major_id=item.major_id,
                   major_name = item.major_name,
                   human_amount = item.human_amount,
                   engage_type = item.engage_type,
                   deadline = item.deadline,
                   changer = item.changer,
                   change_time = item.change_time,
                   major_describe = item.major_describe,
                   engage_required = item.engage_required,
                   register=item.register,
                   regist_time=item.regist_time
               };
                list2.Add(sd);
            }
            return list2;
        }

        public int Add(engage_major_releaseModel st)
        {
            //把DTO转为EO
            engage_major_release est = new engage_major_release()
            {
                Id = st.Id,
                first_kind_id = st.first_kind_id,
                first_kind_name = st.first_kind_name,
                second_kind_id = st.second_kind_id,
                second_kind_name = st.second_kind_name,
                third_kind_id = st.third_kind_id,
                third_kind_name = st.third_kind_name,
                major_kind_id = st.major_kind_id,
                major_kind_name = st.major_kind_name,
                major_id = st.major_id,
                major_name = st.major_name,
                human_amount = st.human_amount,
                engage_type = st.engage_type,
                deadline = st.deadline,
                register = st.register,
                changer = st.changer,
                regist_time = st.regist_time,
                change_time = st.change_time,
                major_describe = st.major_describe,
                engage_required = st.engage_required,
            };
            return Add(est);
        }

        public int Del(Model.engage_major_releaseModel st)
        {
            engage_major_release est = new engage_major_release()
            {
                Id = st.Id

            };
            return Delete(est);
        }

        public List<Model.engage_major_releaseModel> Select()
        {
            List<engage_major_release> list = SelectAll();
            List<engage_major_releaseModel> list2 = new List<engage_major_releaseModel>();
            foreach (engage_major_release item in list)
            {
                engage_major_releaseModel sm = new engage_major_releaseModel()
                {
                    Id = item.Id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    third_kind_id = item.third_kind_id,
                    third_kind_name = item.third_kind_name,
                    major_kind_id = item.major_kind_id,
                    major_kind_name = item.major_kind_name,
                    major_id = item.major_id,
                    major_name = item.major_name,
                    human_amount = item.human_amount,
                    engage_type = item.engage_type,
                    deadline = item.deadline,
                    register = item.register,
                    changer = item.changer,
                    regist_time = item.regist_time,
                    change_time = item.change_time,
                    major_describe = item.major_describe,
                    engage_required = item.engage_required,
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int Update(engage_major_releaseModel st)
        {
            engage_major_release est = new engage_major_release()
            {
                Id = st.Id,
                first_kind_id = st.first_kind_id,
                first_kind_name = st.first_kind_name,
                second_kind_id = st.second_kind_id,
                second_kind_name = st.second_kind_name,
                third_kind_id = st.third_kind_id,
                third_kind_name = st.third_kind_name,
                major_kind_id = st.major_kind_id,
                major_kind_name = st.major_kind_name,
                major_id = st.major_id,
                major_name = st.major_name,
                human_amount = st.human_amount,
                engage_type = st.engage_type,
                deadline = st.deadline,
                changer = st.changer,
                change_time = st.change_time,
                major_describe = st.major_describe,
                engage_required = st.engage_required,
                regist_time=st.regist_time,
                register=st.register
            };
            return Update(est);
        }

        public List<engage_major_releaseModel> Fenye(int dqy) {
            int rows = 0;
            List<engage_major_release> list = FenYe<int>(e => e.Id, e => e.Id> 0, ref rows, dqy, 3) ;
            List<engage_major_releaseModel> list2 = new List<engage_major_releaseModel>();
            foreach (engage_major_release item in list)
            {
                engage_major_releaseModel um = new engage_major_releaseModel()
                {
                    Id = item.Id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    third_kind_id = item.third_kind_id,
                    third_kind_name = item.third_kind_name,
                    major_kind_id = item.major_kind_id,
                    major_kind_name = item.major_kind_name,
                    major_id = item.major_id,
                    major_name = item.major_name,
                    human_amount = item.human_amount,
                    engage_type = item.engage_type,
                    deadline = item.deadline,
                    register = item.register,
                    changer = item.changer,
                    regist_time = item.regist_time,
                    change_time = item.change_time,
                    major_describe = item.major_describe,
                    engage_required = item.engage_required,
                };
                list2.Add(um);
            }     
            return list2;
        }

        public int Row() {
            int rows = 0;
            List<engage_major_release> list = FenYe<int>(e => e.Id, e => e.Id> 0, ref rows, 1, 3);
            return rows;
        }


        public int Pages()
        {
            int rows = 0;
            List<engage_major_release> list = FenYe<int>(e => e.Id, e => e.Id > 0, ref rows, 1, 3);
            double page = rows / 3.00;
            return int.Parse(Math.Ceiling(page).ToString());
        }

        public List<engage_major_releaseModel> SelectByName(engage_major_releaseModel st)
        {
            List<engage_major_release> list = SelectBy(e => e.major_kind_id.Equals(st.major_kind_id));
            List<engage_major_releaseModel> list2 = new List<engage_major_releaseModel>();
            foreach (var item in list)
            {
                engage_major_releaseModel sd = new engage_major_releaseModel()
                {
                    Id = item.Id,
                    major_kind_id = item.major_kind_id,
                    major_kind_name = item.major_kind_name,
                };
                list2.Add(sd);
            }
            return list2;
        }

        public List<engage_major_releaseModel> SelectByNamee(engage_major_releaseModel st)
        {
            List<engage_major_release> list = SelectBy(e => e.major_id.Equals(st.major_id));
            List<engage_major_releaseModel> list2 = new List<engage_major_releaseModel>();
            foreach (var item in list)
            {
                engage_major_releaseModel sd = new engage_major_releaseModel()
                {
                    Id = item.Id,
                    major_id = item.major_id,
                    major_name = item.major_name,
                };
                list2.Add(sd);
            }
            return list2;
        }
    }
}
