using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDAO
{
    public interface Iconfig_file_second_kindDAO
    {
        int Add(config_file_second_kindModel st);
        int Del(config_file_second_kindModel st);
         int Update(config_file_second_kindModel st);
        List<config_file_second_kindModel> Select();

        object Se();
        List<config_file_second_kindModel> SelectBy(config_file_second_kindModel st);

        List<config_file_second_kindModel> SelectByName(config_file_second_kindModel st);

        List<config_file_second_kindModel> SeBy(String Id);
    }
}
