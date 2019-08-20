using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IntDAO;
using IOC;
using lntBLL;
namespace BLL
{
    public class public_charBLL : ISpublic_charBLL
    {
        ISpublic_charDAO pc = IocCreate.Createpublic_charDAO();
        public int Add(public_charModel st)
        {
            return pc.Add(st);
        }

        public int Del(public_charModel st)
        {
            return pc.Del(st);
        }

        public List<public_charModel> Select()
        {
            return pc.Select();
        }

        public List<public_charModel> SelectBy(public_charModel st)
        {
            return pc.SelectBy(st);
        }

        public int Update(public_charModel st)
        {
            return pc.Update(st);
        }
    }
}
