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
    public class config_public_charBLL:Iconfig_public_charBLL
    {
      Iconfig_public_charDAO ist = IocCreate.Createconfig_public_charDAO();

        public List<config_public_charModel> SelectBy(config_public_charModel st)
        {
            return ist.SelectBy(st);
        }

        public int Add(config_public_charModel st)
        {
            return ist.Add(st);
        }

        public int Del(config_public_charModel st)
        {
            return ist.Del(st);
        }

        public List<config_public_charModel> Select()
        {
            return ist.Select();
        }

        public int Update(config_public_charModel st)
        {
            return ist.Update(st);
        }
    }
}
