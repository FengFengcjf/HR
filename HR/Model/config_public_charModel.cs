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
        [Required(ErrorMessage = "�������಻��Ϊ��!")]
        public string attribute_kind { get; set; }
        [Required(ErrorMessage = "�������Ʋ���Ϊ��!")]

        public System.String attribute_name {get;set;} 
    }
}
