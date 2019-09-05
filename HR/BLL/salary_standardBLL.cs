using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lntBLL;
using Model;
using IntDAO;
using IOC;

namespace BLL
{
    public class salary_standardBLL:Isalary_standardBLL
    {
      Isalary_standardDAO ist = IocCreate.Createsalary_standardDAO();

        public List<salary_standardModel> SelectBy(salary_standardModel st)
        {
            return ist.SelectBy(st);
        }

        public int Add(salary_standardModel st)
        {
            return ist.Add(st);
        }

        public int Del(salary_standardModel st)
        {
            return ist.Del(st);
        }

        public List<salary_standardModel> Select()
        {
            return ist.Select();
        }

        public int Update(salary_standardModel st)
        {
            return ist.Update(st);
        }
    }
}
