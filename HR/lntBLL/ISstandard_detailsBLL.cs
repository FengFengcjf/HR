using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lntBLL
{
    public interface ISstandard_detailsBLL
    {
        int Add(standard_detailsModel st);
        int Del(standard_detailsModel st);
        int Update(standard_detailsModel st);
        List<standard_detailsModel> Select();
        List<standard_detailsModel> SelectBy(standard_detailsModel st);
    }
}
