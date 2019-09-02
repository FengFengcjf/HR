using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class config_major_kindModel
    {  

        public System.Int16 Id {get;set;}

        [Required(ErrorMessage = "编号不能为空!")]
       
        public System.String major_kind_id {get;set;}
        [Required(ErrorMessage = "名称不能为空!")]
        public System.String major_kind_name {get;set;} 
    }
}
