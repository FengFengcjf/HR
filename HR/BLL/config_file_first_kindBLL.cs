using IntDAO;
using IOC;
using lntBLL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class config_file_first_kindBLL : Iconfig_file_first_kindBLL
    {
        Iconfig_file_first_kindDAO ist = IocCreate.Createconfig_file_first_kindDAO();

        public List<config_file_first_kindModel> SelectBy(config_file_first_kindModel st)
        {
            return ist.SelectBy(st);
        }

        public int Add(config_file_first_kindModel st)
        {
            return ist.Add(st);
        }

        public int Del(config_file_first_kindModel st)
        {
            return ist.Del(st);
        }

        public List<config_file_first_kindModel> Select()
        {
            return ist.Select();
        }

        public int Update(config_file_first_kindModel st)
        {
            return ist.Update(st);
        }

        public object Se()
        {
            return ist.Se();
        }

        public List<config_file_first_kindModel> SelectByName(config_file_first_kindModel st)
        {
            return ist.SelectByName(st);
        }
    }
}
