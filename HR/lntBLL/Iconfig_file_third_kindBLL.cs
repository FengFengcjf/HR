using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lntBLL
{
    public interface Iconfig_file_third_kindBLL
    {
        int Add(config_file_third_kindModel st);
        int Del(config_file_third_kindModel st);
        int Update(config_file_third_kindModel st);
        List<config_file_third_kindModel> Select();

        object Se();
        List<config_file_third_kindModel> SelectBy(config_file_third_kindModel st);

        List<config_file_third_kindModel> SeBy(String Id);

        List<config_file_third_kindModel> SelectByName(config_file_third_kindModel st);
    }
}

