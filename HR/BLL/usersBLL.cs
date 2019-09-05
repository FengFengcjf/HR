using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lntBLL;
using Model;
using IntDAO;
using IOC;

namespace BLL
{
    public class usersBLL:IusersBLL
    {
      IusersDAO ist = IocCreate.CreateusersDAO();

        public List<usersModel> SelectBy(usersModel st)
        {
            return ist.SelectBy(st);
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
    }
}
