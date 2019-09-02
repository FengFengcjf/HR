using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lntBLL
{
    public interface Iconfig_major_kindBLL
    {
        int Add(config_major_kindModel st);
        int Del(config_major_kindModel st);
        int Update(config_major_kindModel st);
        List<config_major_kindModel> Select();
            List<config_major_kindModel> SelectBy(config_major_kindModel st);

        List<config_major_kindModel> SelectByName(config_major_kindModel st);
    }
}

