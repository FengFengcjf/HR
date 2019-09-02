using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lntBLL
{
    public interface IusersBLL
    {
        int Add(usersModel st);
        int Del(usersModel st);
        int Update(usersModel st);
        List<usersModel> Select();
        List<usersModel> SelectBy(usersModel st);
        usersModel Login(usersModel st);
       DataTable show();
        object JXMain(int gid, string fid);
        Dictionary<string, object> Fenye(int pageIndex);
    }
}

