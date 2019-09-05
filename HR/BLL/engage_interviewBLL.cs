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
    public class engage_interviewBLL:Iengage_interviewBLL
    {
      Iengage_interviewDAO ist = IocCreate.Createengage_interviewDAO();

        public List<engage_interviewModel> SelectBy(engage_interviewModel st)
        {
            return ist.SelectBy(st);
        }

        public List<engage_interviewModel> SelectBy2(String ii)
        {
            return ist.SelectBy2(ii);
        }

        public int Add(engage_interviewModel st)
        {
            return ist.Add(st);
        }

        public int Del(engage_interviewModel st)
        {
            return ist.Del(st);
        }

        public List<engage_interviewModel> Select()
        {
            return ist.Select();
        }

        public int Update(engage_interviewModel st)
        {
            return ist.Update(st);
        }

        public List<engage_interviewModel> Fenye2(int dqy)
        {
            return ist.Fenye2(dqy);
        }

        public int Row()
        {
            return ist.Row();
        }

        public int Pages()
        {
            return ist.Pages();
        }
    }
}
