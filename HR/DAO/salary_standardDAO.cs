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
    public class salary_standardDAO:DaoBase<salary_standard>,Isalary_standardDAO
    {
          public List<salary_standardModel> SelectBy(salary_standardModel st)
        {
            List<salary_standard> list = SelectBy(e => e.Id.Equals(st.Id));
            List<salary_standardModel> list2 = new List<salary_standardModel>();
            foreach (var item in list)
            {
               salary_standardModel sd = new salary_standardModel()
                {
                    Id =item.Id
                };
                list2.Add(sd);
            }
            return list2;
        }

        public int Add(salary_standardModel st)
        {
            //把DTO转为EO
            salary_standard est = new salary_standard()
            {
                Id = st.Id
            };
            return Add(est);
        }

        public int Del(Model.salary_standardModel st)
        {
            salary_standard est = new salary_standard()
            {
                Id = st.Id

            };
            return Delete(est);
        }

        public List<Model.salary_standardModel> Select()
        {
            List<salary_standard> list = SelectAll();
            List<salary_standardModel> list2 = new List<salary_standardModel>();
            foreach (salary_standard item in list)
            {
                salary_standardModel sm = new salary_standardModel()
                {
                    Id = item.Id,
                  
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int Update(salary_standardModel st)
        {
            salary_standard est = new salary_standard()
            {
                Id = st.Id
            };
            return Update(est);
        }
    }
}
