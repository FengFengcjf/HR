using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity
{
    public class users
    {  

        public System.Int32 Id
        {
          get;set;
        }
        [Required(ErrorMessage = "名称不能为空!")]

        public System.String u_name
        {
          get;set;
        }

        [Required(ErrorMessage = "真实姓名不能为空!")]
        
        public System.String u_true_name
        {
          get;set;
        }

        [Required(ErrorMessage = "密码不能为空!")]
        [StringLength(maximumLength: 20, ErrorMessage = "密码不能超过20位长度")]//规定长度
        public System.String u_password
        {
          get;set;
        }

        public System.Int32 Gid
        {
            get; set;
        }     
    }
}
