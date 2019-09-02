using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IntDAO
{
   public interface Iconfig_file_first_kindDAO
    {
        int Add(config_file_first_kindModel st);
        int Del(config_file_first_kindModel st);
        int Update(config_file_first_kindModel st);
        List<config_file_first_kindModel> Select();


        List<config_file_first_kindModel> SelectByName(config_file_first_kindModel st);
        object Se();
        List<config_file_first_kindModel> SelectBy(config_file_first_kindModel st);
    }
}
