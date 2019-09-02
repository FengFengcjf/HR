using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class config_public_charModel
    {  

        public System.Int16 Id {get;set;}
        [Required(ErrorMessage = "属性种类不能为空!")]
        public string attribute_kind { get; set; }
        [Required(ErrorMessage = "属性名称不能为空!")]

        public System.String attribute_name {get;set;} 
    }
}
