using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDAO
{
    public interface Ihuman_fileDAO
    {
        int Add(human_fileModel st);
        int Del(human_fileModel st);
         int Update(human_fileModel st);
        List<human_fileModel> Select();
       List<human_fileModel> SelectBy(human_fileModel st);

        List<human_fileModel> Fenye(int dqy);

        int Row();
        int Pages();

    }
}
