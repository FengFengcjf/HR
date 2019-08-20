using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using EFentity;
using IntDAO;
namespace DAO
{
   public class public_charDAO:DaoBase<public_char>,ISpublic_charDAO
    {
        public List<public_charModel> SelectBy(public_charModel st)
        {
            List<public_char> list = SelectBy(e => e.Id.Equals(st.Id));
            List<public_charModel> list2 = new List<public_charModel>();
            foreach (var item in list)
            {
                public_charModel sd = new public_charModel()
                {
                    Id = item.Id,
                   attribute_name=item.attribute_name,
                   attribute_kind=item.attribute_kind
                    
                };
                list2.Add(sd);
            }
            return list2;
        }

        public int Add(public_charModel st)
        {
            //把DTO转为EO
            public_char est = new public_char()
            {
                Id = st.Id,
                attribute_name = st.attribute_name,
                attribute_kind = st.attribute_kind
            };
            return Add(est);
        }

        public int Del(public_charModel st)
        {
            public_char est = new public_char()
            {
                Id = st.Id

            };
            return Delete(est);
        }

        public List<public_charModel> Select()
        {
            List<public_char> list = SelectAll();
            List<public_charModel> list2 = new List<public_charModel>();
            foreach (public_char item in list)
            {
                public_charModel sm = new public_charModel()
                {
                    Id = item.Id,
                    attribute_name = item.attribute_name,
                    attribute_kind = item.attribute_kind
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int Update(public_charModel st)
        {
            public_char est = new public_char()
            {
                Id = st.Id,
                attribute_name = st.attribute_name,
                attribute_kind = st.attribute_kind
            };
            return Update(est);
        }


    }
}
