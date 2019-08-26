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
    public class config_public_charDAO:DaoBase<config_public_char>,Iconfig_public_charDAO
    {
          public List<config_public_charModel> SelectBy(config_public_charModel st)
        {
            List<config_public_char> list = SelectBy(e => e.attribute_kind.Equals(st.attribute_kind));
            List<config_public_charModel> list2 = new List<config_public_charModel>();
            foreach (var item in list)
            {
               config_public_charModel sd = new config_public_charModel()
                {
                   Id=item.Id,
                    attribute_kind = item.attribute_kind,
                    attribute_name=item.attribute_name
               };
                list2.Add(sd);
            }
            return list2;
        }

        public int Add(config_public_charModel st)
        {
            //把DTO转为EO
            config_public_char est = new config_public_char()
            {
                Id = st.Id,
                attribute_kind = st.attribute_kind,
                attribute_name = st.attribute_name
            };
            return Add(est);
        }

        public int Del(Model.config_public_charModel st)
        {
            config_public_char est = new config_public_char()
            {
                Id = st.Id

            };
            return Delete(est);
        }

        public List<Model.config_public_charModel> Select()
        {
            List<config_public_char> list = SelectAll();
            List<config_public_charModel> list2 = new List<config_public_charModel>();
            foreach (config_public_char item in list)
            {
                config_public_charModel sm = new config_public_charModel()
                {
                    Id = item.Id,
                    attribute_kind=item.attribute_kind,
                    attribute_name=item.attribute_name
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int Update(config_public_charModel st)
        {
            config_public_char est = new config_public_char()
            {
                Id = st.Id
            };
            return Update(est);
        }
    }
}
