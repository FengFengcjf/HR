using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDAO
{
    public interface Iengage_resumeDAO
    {
        int Add(engage_resumeModel st);
        int Del(engage_resumeModel st);
         int Update(engage_resumeModel st);
        List<engage_resumeModel> Select();
       List<engage_resumeModel> SelectBy(engage_resumeModel st);

        List<engage_resumeModel> SeBy(int dqy,String Qid, String Pid,String Guan, String Start, String End, String Zt);
        List<engage_resumeModel> SeByy(int dqy, String Qid, String Pid, String Guan, String Start, String End, String Zt);
        List<engage_resumeModel> Fenye(int dqy);


        List<engage_resumeModel> Fenye2(int dqy);
        int Row();
        int Pages();
    }
}
