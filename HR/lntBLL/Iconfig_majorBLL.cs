using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lntBLL
{
    public interface Iconfig_majorBLL
    {
        int Add(config_majorModel st);
        int Del(config_majorModel st);
        int Update(config_majorModel st);
        List<config_majorModel> Select();
            List<config_majorModel> SelectBy(config_majorModel st);
    }
}

