﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace lntBLL
{
    public interface Iconfig_file_first_kindBLL
    {
        int Add(config_file_first_kindModel st);
        int Del(config_file_first_kindModel st);
        int Update(config_file_first_kindModel st);
        List<config_file_first_kindModel> Select();
        List<config_file_first_kindModel> SelectBy(config_file_first_kindModel st);

        List<config_file_first_kindModel> SelectByName(config_file_first_kindModel st);
        object Se();
    }
}
