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
    public class config_file_first_kindDAO : DaoBase<config_file_first_kind>, Iconfig_file_first_kindDAO
    {
        public List<config_file_first_kindModel> SelectBy(config_file_first_kindModel st)
        {
            List<config_file_first_kind> list = SelectBy(e => e.Id.Equals(st.Id));
            List<config_file_first_kindModel> list2 = new List<config_file_first_kindModel>();
            foreach (var item in list)
            {
                config_file_first_kindModel sd = new config_file_first_kindModel()
                {
                    Id = item.Id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    first_kind_salary_id = item.first_kind_salary_id,
                    first_kind_sale_id = item.first_kind_sale_id
                };
                list2.Add(sd);
            }
            return list2;
        }

        public int Add(config_file_first_kindModel st)
        {
            //把DTO转为EO
            int i = int.Parse(Se().ToString())+1;
            config_file_first_kind est = new config_file_first_kind()
            {
                Id = st.Id,
                first_kind_id = i.ToString(),
                first_kind_name = st.first_kind_name,
                first_kind_salary_id = st.first_kind_salary_id,
                first_kind_sale_id = st.first_kind_sale_id

            };
            return Add(est);
        }

        public int Del(Model.config_file_first_kindModel st)
        {
            config_file_first_kind est = new config_file_first_kind()
            {
                Id = st.Id,
                first_kind_id = st.first_kind_id,
                first_kind_name = st.first_kind_name,
                first_kind_salary_id = st.first_kind_salary_id,
                first_kind_sale_id = st.first_kind_sale_id

            };
            return Delete(est);
        }

        public List<Model.config_file_first_kindModel> Select()
        {
            List<config_file_first_kind> list = SelectAll();
            List<config_file_first_kindModel> list2 = new List<config_file_first_kindModel>();
            foreach (config_file_first_kind item in list)
            {
                config_file_first_kindModel sm = new config_file_first_kindModel()
                {
                    Id = item.Id,
                    first_kind_id=item.first_kind_id,
                    first_kind_name=item.first_kind_name,
                    first_kind_salary_id=item.first_kind_salary_id,
                    first_kind_sale_id=item.first_kind_sale_id
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int Update(config_file_first_kindModel st)
        {
            config_file_first_kind est = new config_file_first_kind()
            {
                Id = st.Id,
                first_kind_id = st.first_kind_id,
                first_kind_name = st.first_kind_name,
                first_kind_salary_id = st.first_kind_salary_id,
                first_kind_sale_id = st.first_kind_sale_id
            };
            return Update(est);
        }

        public object  Se() {
            string sql = "select max(first_kind_id) from config_file_first_kind";
            return DBHelper.SelectSinger(sql);
        }

        public List<config_file_first_kindModel> SelectByName(config_file_first_kindModel st)
        {
            List<config_file_first_kind> list = SelectBy(e => e.first_kind_id.Equals(st.first_kind_id));
            List<config_file_first_kindModel> list2 = new List<config_file_first_kindModel>();
            foreach (var item in list)
            {
                config_file_first_kindModel sd = new config_file_first_kindModel()
                {
                    Id = item.Id,
                    first_kind_id = item.first_kind_id,
                    first_kind_salary_id = item.first_kind_salary_id,
                    first_kind_sale_id = item.first_kind_sale_id,
                    first_kind_name = item.first_kind_name,
                };
                list2.Add(sd);
            }
            return list2;
        }
    }
}
