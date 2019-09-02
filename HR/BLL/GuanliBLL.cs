using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntDAO;
using lntBLL;
using Model;
using IOC;
namespace BLL
{
  public  class GuanliBLL:IGuanliBLL
    {
        IGuanliDAO ist = IocCreate.CreateGuanliDAO();

        public List<GuanliModel> SelectBy(GuanliModel st)
        {
            return ist.SelectBy(st);
        }

        public int Add(GuanliModel st)
        {
            return ist.Add(st);
        }

        public int Del(GuanliModel st)
        {
            return ist.Del(st);
        }

        public List<GuanliModel> Select()
        {
            return ist.Select();
        }

        public int Update(GuanliModel st)
        {
            return ist.Update(st);
        }
        public Dictionary<string, object> Fenye(int pageIndex)
        {
            return ist.Fenye(pageIndex);
        }
    }
}
