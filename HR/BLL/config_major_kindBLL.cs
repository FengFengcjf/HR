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
    public class config_major_kindBLL:Iconfig_major_kindBLL
    {
      Iconfig_major_kindDAO ist = IocCreate.Createconfig_major_kindDAO();

        public List<config_major_kindModel> SelectBy(config_major_kindModel st)
        {
            return ist.SelectBy(st);
        }

        public int Add(config_major_kindModel st)
        {
            return ist.Add(st);
        }

        public int Del(config_major_kindModel st)
        {
            return ist.Del(st);
        }

        public List<config_major_kindModel> Select()
        {
            return ist.Select();
        }

        public int Update(config_major_kindModel st)
        {
            return ist.Update(st);
        }
    }
}
