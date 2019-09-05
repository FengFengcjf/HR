using EFentity;
using IntDAO;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class config_file_third_kindDAO:DaoBase<config_file_third_kind>,Iconfig_file_third_kindDAO
    {
          public List<config_file_third_kindModel> SelectBy(config_file_third_kindModel st)
        {
            List<config_file_third_kind> list = SelectBy(e => e.Id.Equals(st.Id));
            List<config_file_third_kindModel> list2 = new List<config_file_third_kindModel>();
            foreach (var item in list)
            {
               config_file_third_kindModel sd = new config_file_third_kindModel()
                {
                    Id =item.Id,
                   first_kind_id=item.first_kind_id,
                   first_kind_name = item.first_kind_name,
                   second_kind_id = item.second_kind_id,
                   second_kind_name = item.second_kind_name,
                   third_kind_id = item.third_kind_id,
                   third_kind_name = item.third_kind_name,
                   third_kind_sale_id = item.third_kind_sale_id,
                   third_kind_is_retail = item.third_kind_is_retail,
               };
                list2.Add(sd);
            }
            return list2;
        }

        public int Add(config_file_third_kindModel st)
        {
            //把DTO转为EO
            int i = int.Parse(Se().ToString())+1;
            config_file_third_kind est = new config_file_third_kind()
            {
                Id = st.Id,
                first_kind_id = st.first_kind_id,
                first_kind_name = st.first_kind_name,
                second_kind_id = st.second_kind_id,
                second_kind_name = st.second_kind_name,
                third_kind_id = i.ToString(),
                third_kind_name = st.third_kind_name,
                third_kind_sale_id = st.third_kind_sale_id,
                third_kind_is_retail = st.third_kind_is_retail,
            };
            return Add(est);
        }

        public int Del(Model.config_file_third_kindModel st)
        {
            config_file_third_kind est = new config_file_third_kind()
            {
                Id = st.Id,
                first_kind_id = st.first_kind_id,
                first_kind_name = st.first_kind_name,
                second_kind_id = st.second_kind_id,
                second_kind_name = st.second_kind_name,
                third_kind_id = st.third_kind_id,
                third_kind_name = st.third_kind_name,
                third_kind_sale_id = st.third_kind_sale_id,
                third_kind_is_retail = st.third_kind_is_retail,

            };
            return Delete(est);
        }

        public List<Model.config_file_third_kindModel> Select()
        {
            List<config_file_third_kind> list = SelectAll();
            List<config_file_third_kindModel> list2 = new List<config_file_third_kindModel>();
            foreach (config_file_third_kind item in list)
            {
                config_file_third_kindModel sm = new config_file_third_kindModel()
                {
                    Id = item.Id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    third_kind_id = item.third_kind_id,
                    third_kind_name = item.third_kind_name,
                    third_kind_sale_id = item.third_kind_sale_id,
                    third_kind_is_retail = item.third_kind_is_retail,
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int Update(config_file_third_kindModel st)
        {
            config_file_third_kind est = new config_file_third_kind()
            {
                Id = st.Id,
                first_kind_id=st.first_kind_id,
                first_kind_name = st.first_kind_name,
                second_kind_id=st.second_kind_id,
                second_kind_name = st.second_kind_name,
                third_kind_id = st.third_kind_id,
                third_kind_name = st.third_kind_name,
                third_kind_sale_id = st.third_kind_sale_id,
                third_kind_is_retail = st.third_kind_is_retail,
            };
            return Update(est);
        }

        public object Se()
        {
            string sql = "select max(third_kind_id) from config_file_third_kind";
            return DBHelper.SelectSinger(sql);
        }

        public List<config_file_third_kindModel> SeBy(String Id)
        {
            List<config_file_third_kind> list = SelectBy(e => e.second_kind_id.Equals(Id));
            List<config_file_third_kindModel> list2 = new List<config_file_third_kindModel>();
            foreach (var item in list)
            {
                config_file_third_kindModel sd = new config_file_third_kindModel()
                {
                    Id = item.Id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    third_kind_id = item.third_kind_id,
                    third_kind_name = item.third_kind_name,
                    third_kind_sale_id = item.third_kind_sale_id,
                    third_kind_is_retail = item.third_kind_is_retail,
                };
                list2.Add(sd);
            }
            return list2;
        }

        public List<config_file_third_kindModel> SelectByName(config_file_third_kindModel st)
        {
            List<config_file_third_kind> list = SelectBy(e => e.third_kind_id.Equals(st.third_kind_id));
            List<config_file_third_kindModel> list2 = new List<config_file_third_kindModel>();
            foreach (var item in list)
            {
                config_file_third_kindModel sd = new config_file_third_kindModel()
                {
                    Id = item.Id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,                  
                    third_kind_id = item.third_kind_id,
                    third_kind_name = item.third_kind_name,
                    third_kind_sale_id = item.third_kind_sale_id,
                    third_kind_is_retail = item.third_kind_is_retail,               
                    
                };
                list2.Add(sd);
            }
            return list2;
        }
    }
}
