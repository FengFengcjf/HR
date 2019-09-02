using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lntBLL;
using Model;
using IntDAO;
using IOC;
using System.Data;

namespace BLL
{
    public class usersBLL:IusersBLL
    {
      IusersDAO ist = IocCreate.CreateusersDAO();

        public List<usersModel> SelectBy(usersModel st)
        {
            return ist.SelectBy(st);
        }
        public usersModel Login(usersModel st)
        {
            return ist.Login(st);
        }

        public int Add(usersModel st)
        {
            return ist.Add(st);
        }

        public int Del(usersModel st)
        {
            return ist.Del(st);
        }

        public List<usersModel> Select()
        {
            return ist.Select();
        }

        public int Update(usersModel st)
        {
            return ist.Update(st);
        }
        public DataTable show()
        {
            return ist.show();
        }
        public object JXMain(int gid, string fid)
        {
            return ist.JXMain(gid,fid);
        }
        public Dictionary<string, object> Fenye(int pageIndex)
        {
            return ist.Fenye(pageIndex);
        }
    }
}
