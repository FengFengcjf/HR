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

        List<engage_resumeModel> SeBy(String Qid, String Pid,String Guan, String Start, String End);

        List<engage_resumeModel> Fenye(int dqy);

        int Row();
        int Pages();
    }
}
