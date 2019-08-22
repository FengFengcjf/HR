using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace lntBLL
{
  public  interface ISpublic_charBLL
    {
        int Add(public_charModel st);
        int Del(public_charModel st);
        int Update(public_charModel st);
        List<public_charModel> Select();
        List<public_charModel> SelectBy(public_charModel st);
    }
}
