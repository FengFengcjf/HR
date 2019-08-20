using IntDAO;
using IOC;
using lntBLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
 public   class standard_detailsBLL: ISstandard_detailsBLL
    {
        ISstandard_detailsDAO ist = IocCreate.Createstandard_detailsDAO();

        public List<standard_detailsModel> SelectBy(standard_detailsModel st)
        {
            return ist.SelectBy(st);
        }

        public int Add(standard_detailsModel st)
        {
            return ist.Add(st);
        }

        public int Del(standard_detailsModel st)
        {
            return ist.Del(st);
        }

        public List<standard_detailsModel> Select()
        {
            return ist.Select();
        }

        public int Update(standard_detailsModel st)
        {
            return ist.Update(st);
        }
    }
}
