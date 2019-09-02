using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDAO
{
    public interface IusersDAO
    {
        int Add(usersModel st);
        int Del(usersModel st);
         int Update(usersModel st);
        List<usersModel> Select();
       List<usersModel> SelectBy(usersModel st);
        object JXMain(int gid, string fid);
        usersModel Login(usersModel st);
        DataTable show();
        Dictionary<string, object> Fenye(int pageIndex);
    }
}
