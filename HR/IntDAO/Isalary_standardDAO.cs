using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDAO
{
    public interface Isalary_standardDAO
    {
        int Add(salary_standardModel st);
        int Del(salary_standardModel st);
         int Update(salary_standardModel st);
        List<salary_standardModel> Select();
       List<salary_standardModel> SelectBy(salary_standardModel st);
    }
}
