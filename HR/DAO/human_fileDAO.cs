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
    public class human_fileDAO:DaoBase<human_file>,Ihuman_fileDAO
    {
          public List<human_fileModel> SelectBy(human_fileModel st)
        {
            List<human_file> list = SelectBy(e => e.Id.Equals(st.Id));
            List<human_fileModel> list2 = new List<human_fileModel>();
            foreach (var item in list)
            {
               human_fileModel sd = new human_fileModel()
                {
                    Id =item.Id
                };
                list2.Add(sd);
            }
            return list2;
        }

        public int Add(human_fileModel st)
        {
            int i = int.Parse(Se().ToString()) + 1;
            //把DTO转为EO
            human_file est = new human_file()
            {
                Id = st.Id,
                human_id = i.ToString(),
                human_name = st.human_name,
                human_address = st.human_address,
                human_postcode = st.human_postcode,
                human_major_kind_id = st.human_major_kind_id,
                human_major_kind_name = st.human_major_kind_name,
                human_major_id = st.human_major_id,
                hunma_major_name = st.hunma_major_name,
                human_telephone = st.human_telephone,
                human_mobilephone = st.human_mobilephone,
                human_email = st.human_email,
                human_hobby = st.human_hobby,
                human_speciality = st.human_speciality,
                human_sex = st.human_sex,
                human_religion = st.human_religion,
                human_party = st.human_party,
                human_nationality = st.human_nationality,
                human_race = st.human_race,
                human_birthday = st.human_birthday,
                human_age = st.human_age,
                human_birthplace = st.human_birthplace,
                human_educated_degree = st.human_educated_degree,
                human_educated_years = st.human_educated_years,
                human_educated_major = st.human_educated_major,
                human_id_card = st.human_id_card,
                remark = st.remark,
                regist_time=DateTime.Now,
                check_time=DateTime.Now,
                change_time=DateTime.Now,
                lastly_change_time=DateTime.Now,
                delete_time=DateTime.Now,
                recovery_time=DateTime.Now,
                check_status = "待复核"
            };
            return Add(est);
        }

        public object Se()
        {
            string sql = "select max(human_id ) from human_file";
            return DBHelper.SelectSinger(sql);
        }


        public List<human_fileModel> Fenye(int dqy)
        {
            int rows = 0;
            List<human_file> list = FenYe<int>(e => e.Id, e => e.Id > 0, ref rows, dqy, 3);
            List<human_fileModel> list2 = new List<human_fileModel>();
            foreach (human_file item in list)
            {
                human_fileModel um = new human_fileModel()
                {
                    Id = item.Id,
                    human_id=item.human_id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    third_kind_id = item.third_kind_id,
                    third_kind_name = item.third_kind_name,
                    register = item.register,
                    changer = item.changer,
                    regist_time = item.regist_time,
                    change_time = item.change_time,
                    human_name = item.human_name,
                    human_address = item.human_address,
                    human_postcode = item.human_postcode,
                    human_major_kind_id = item.human_major_kind_id,
                    human_major_kind_name = item.human_major_kind_name,
                    human_major_id = item.human_major_id,
                    hunma_major_name = item.hunma_major_name,
                    human_telephone = item.human_telephone,
                    human_mobilephone = item.human_mobilephone,
                    human_email = item.human_email,
                    human_hobby = item.human_hobby,
                    human_speciality = item.human_speciality,
                    human_sex = item.human_sex,
                    human_religion = item.human_religion,
                    human_party = item.human_party,
                    human_nationality = item.human_nationality,
                    human_race = item.human_race,
                    human_birthday = item.human_birthday,
                    human_age = item.human_age,
                    human_birthplace = item.human_birthplace,
                    human_educated_degree = item.human_educated_degree,
                    human_educated_years = item.human_educated_years,
                    human_educated_major = item.human_educated_major,
                    human_id_card = item.human_id_card,
                    remark = item.remark,
                    check_status=item.check_status
                };
                list2.Add(um);
            }
            return list2;
        }

        public int Row()
        {
            int rows = 0;
            List<human_file> list = FenYe<int>(e => e.Id, e => e.Id > 0, ref rows, 1, 3);
            return rows;
        }


        public int Pages()
        {
            int rows = 0;
            List<human_file> list = FenYe<int>(e => e.Id, e => e.Id > 0, ref rows, 1, 3);
            double page = rows / 3.00;
            return int.Parse(Math.Ceiling(page).ToString());
        }


        public int Del(Model.human_fileModel st)
        {
            human_file est = new human_file()
            {
                Id = st.Id

            };
            return Delete(est);
        }

        public List<Model.human_fileModel> Select()
        {
            List<human_file> list = SelectAll();
            List<human_fileModel> list2 = new List<human_fileModel>();
            foreach (human_file item in list)
            {
                human_fileModel sm = new human_fileModel()
                {
                    Id = item.Id
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int Update(human_fileModel st)
        {
            human_file est = new human_file()
            {
                Id = st.Id
            };
            return Update(est);
        }

      
    }
}
