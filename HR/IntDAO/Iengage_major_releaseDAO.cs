using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDAO
{
    public interface Iengage_major_releaseDAO
    {
        int Add(engage_major_releaseModel st);
        int Del(engage_major_releaseModel st);
         int Update(engage_major_releaseModel st);
        List<engage_major_releaseModel> Select();
       List<engage_major_releaseModel> SelectBy(engage_major_releaseModel st);

        List<engage_major_releaseModel> Fenye(int dqy);

        int Row();
        int Pages();

        List<engage_major_releaseModel> SelectByName(engage_major_releaseModel st);

        List<engage_major_releaseModel> SelectByNamee(engage_major_releaseModel st);
    }
}
