using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace lntBLL
{
  public  interface IGuanliBLL
    {
        int Add(GuanliModel st);
        int Del(GuanliModel st);
        int Update(GuanliModel st);
        List<GuanliModel> Select();
        List<GuanliModel> SelectBy(GuanliModel st);
        Dictionary<string, object> Fenye(int pageIndex);
    }
}
