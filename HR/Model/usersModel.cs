using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class usersModel
    {  

        public System.Int32 Id
        {
          get;set;
        }  

        public System.String u_name
        {
          get;set;
        }  

        public System.String u_true_name
        {
          get;set;
        }  

        public System.String u_password
        {
          get;set;
        }
        public System.Int32 Gid
        {
            get; set;
        }
        public System.String gname
        {
            get; set;
        }
        public string Available { get; set; }
    }
}
