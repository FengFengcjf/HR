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
    public class config_majorBLL:Iconfig_majorBLL
    {
      Iconfig_majorDAO ist = IocCreate.Createconfig_majorDAO();

        public List<config_majorModel> SelectBy(config_majorModel st)
        {
            return ist.SelectBy(st);
        }

        public int Add(config_majorModel st)
        {
            return ist.Add(st);
        }

        public int Del(config_majorModel st)
        {
            return ist.Del(st);
        }

        public List<config_majorModel> Select()
        {
            return ist.Select();
        }

        public int Update(config_majorModel st)
        {
            return ist.Update(st);
        }
    }
}
