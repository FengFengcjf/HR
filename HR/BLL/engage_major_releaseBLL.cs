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
    public class engage_major_releaseBLL:Iengage_major_releaseBLL
    {
      Iengage_major_releaseDAO ist = IocCreate.Createengage_major_releaseDAO();

        public List<engage_major_releaseModel> SelectBy(engage_major_releaseModel st)
        {
            return ist.SelectBy(st);
        }

        public int Add(engage_major_releaseModel st)
        {
            return ist.Add(st);
        }

        public int Del(engage_major_releaseModel st)
        {
            return ist.Del(st);
        }

        public List<engage_major_releaseModel> Select()
        {
            return ist.Select();
        }

        public int Update(engage_major_releaseModel st)
        {
            return ist.Update(st);
        }

        public List<engage_major_releaseModel> Fenye(int dqy)
        {
            return ist.Fenye(dqy);
        }

        public int Row()
        {
            return ist.Row();
        }

        public int Pages()
        {
            return ist.Pages();
        }

        public List<engage_major_releaseModel> SelectByName(engage_major_releaseModel st)
        {
            return ist.SelectByName(st);
        }

        public List<engage_major_releaseModel> SelectByNamee(engage_major_releaseModel st)
        {
            return ist.SelectByNamee(st);
        }
    }
}
