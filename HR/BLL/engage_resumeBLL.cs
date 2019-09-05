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

        public List<engage_resumeModel> SeBy(int dqy,String Qid, String Pid,String Guan, String Start, String End,String Zt)
        {
            return ist.SeBy(dqy,Qid, Pid,Guan,Start,End, Zt);
        }

        public List<engage_resumeModel> SeByy(int dqy, String Qid, String Pid, String Guan, String Start, String End, String Zt)
        {
            return ist.SeByy(dqy, Qid, Pid, Guan, Start, End, Zt);
        }

        public List<engage_resumeModel> Fenye(int dqy)
        {
            return ist.Fenye(dqy);
        }

        public List<engage_resumeModel> Fenye2(int dqy)
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
