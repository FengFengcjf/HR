using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDAO
{
    public interface Iconfig_file_third_kindDAO
    {
        int Add(config_file_third_kindModel st);
        int Del(config_file_third_kindModel st);
         int Update(config_file_third_kindModel st);

        object Se();
        List<config_file_third_kindModel> Select();
       List<config_file_third_kindModel> SelectBy(config_file_third_kindModel st);
    }
}
