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

        [Required(ErrorMessage = "��Ų���Ϊ��!")]
       
        public System.String major_kind_id {get;set;}
        [Required(ErrorMessage = "���Ʋ���Ϊ��!")]
        public System.String major_kind_name {get;set;} 
    }
}
