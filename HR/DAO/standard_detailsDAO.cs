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
    public class standard_detailsDAO : DaoBase<standard_details>, ISstandard_detailsDAO
    {
        public List<standard_detailsModel> SelectBy(standard_detailsModel st)
        {
            List<standard_details> list = SelectBy(e => e.Id.Equals(st.Id));
            List<standard_detailsModel> list2 = new List<standard_detailsModel>();
            foreach (var item in list)
            {
                standard_detailsModel sd = new standard_detailsModel()
                {
                    Id =item.Id,
                   standard_id=item.standard_id,
                   standard_name=item.standard_name,
                   item_name=item.item_name,
                   item_id=item.item_id,
                   salary=item.salary
                };
                list2.Add(sd);
            }
            return list2;
        }

        public int Add(standard_detailsModel st)
        {
            //把DTO转为EO
            standard_details est = new standard_details()
            {
                Id = st.Id,
                standard_id = st.standard_id,
                standard_name = st.standard_name,
                item_name = st.item_name,
                item_id = st.item_id,
                salary = st.salary
            };
            return Add(est);
        }

        public int Del(standard_detailsModel st)
        {
            standard_details est = new standard_details()
            {
                Id = st.Id

            };
            return Delete(est);
        }

        public List<Model.standard_detailsModel> Select()
        {
            List<standard_details> list = SelectAll();
            List<standard_detailsModel> list2 = new List<standard_detailsModel>();
            foreach (standard_details item in list)
            {
                standard_detailsModel sm = new standard_detailsModel()
                {
                    Id = item.Id,
                    standard_id = item.standard_id,
                    standard_name = item.standard_name,
                    item_name = item.item_name,
                    item_id = item.item_id,
                    salary = item.salary
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int Update(standard_detailsModel st)
        {
            standard_details est = new standard_details()
            {
                Id = st.Id,
                standard_id = st.standard_id,
                standard_name = st.standard_name,
                item_name = st.item_name,
                item_id = st.item_id,
                salary = st.salary
            };
            return Update(est);
        }

   

      
    }
}
