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
    public class config_major_kindDAO:DaoBase<config_major_kind>,Iconfig_major_kindDAO
    {
          public List<config_major_kindModel> SelectBy(config_major_kindModel st)
        {
            List<config_major_kind> list = SelectBy(e => e.Id.Equals(st.Id));
            List<config_major_kindModel> list2 = new List<config_major_kindModel>();
            foreach (var item in list)
            {
               config_major_kindModel sd = new config_major_kindModel()
                {
                    Id =item.Id
                };
                list2.Add(sd);
            }
            return list2;
        }

        public int Add(config_major_kindModel st)
        {
            //把DTO转为EO
            config_major_kind est = new config_major_kind()
            {
                Id = st.Id,
                major_kind_id=st.major_kind_id,
                major_kind_name=st.major_kind_name
            };
            return Add(est);
        }

        public int Del(Model.config_major_kindModel st)
        {
            config_major_kind est = new config_major_kind()
            {
                Id = st.Id

            };
            return Delete(est);
        }

        public List<Model.config_major_kindModel> Select()
        {
            List<config_major_kind> list = SelectAll();
            List<config_major_kindModel> list2 = new List<config_major_kindModel>();
            foreach (config_major_kind item in list)
            {
                config_major_kindModel sm = new config_major_kindModel()
                {
                    Id = item.Id,
                    major_kind_id=item.major_kind_id,
                    major_kind_name=item.major_kind_name
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int Update(config_major_kindModel st)
        {
            config_major_kind est = new config_major_kind()
            {
                Id = st.Id,
                major_kind_id=st.major_kind_id,
                major_kind_name=st.major_kind_name
            };
            return Update(est);
        }

        public List<config_major_kindModel> SelectByName(config_major_kindModel st)
        {
            List<config_major_kind> list = SelectBy(e => e.major_kind_id.Equals(st.major_kind_id));
            List<config_major_kindModel> list2 = new List<config_major_kindModel>();
            foreach (var item in list)
            {
                config_major_kindModel sd = new config_major_kindModel()
                {
                    Id = item.Id,
                    major_kind_id = item.major_kind_id,
                    major_kind_name = item.major_kind_name,
                };
                list2.Add(sd);
            }
            return list2;
        }
    }
}
