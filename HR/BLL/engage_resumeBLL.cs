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
    public class engage_resumeBLL:Iengage_resumeBLL
    {
      Iengage_resumeDAO ist = IocCreate.Createengage_resumeDAO();

        public List<engage_resumeModel> SelectBy(engage_resumeModel st)
        {
            return ist.SelectBy(st);
        }

        public int Add(engage_resumeModel st)
        {
            return ist.Add(st);
        }

        public int Del(engage_resumeModel st)
        {
            return ist.Del(st);
        }

        public List<engage_resumeModel> Select()
        {
            return ist.Select();
        }

        public int Update(engage_resumeModel st)
        {
            return ist.Update(st);
        }

        public List<engage_resumeModel> SeBy(String Qid, String Pid,String Guan, String Start, String End)
        {
            return ist.SeBy(Qid, Pid,Guan,Start,End);
        }

        public List<engage_resumeModel> Fenye(int dqy)
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
    }
}
