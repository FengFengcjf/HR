using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Model
{
    public class config_file_third_kindModel
    {  

        public System.Int16 Id { get;set; }
        [StringLength(maximumLength: 2, ErrorMessage = "名称不能超过2位长度")]
        public string first_kind_id { get;set; }  

        public string first_kind_name { get;set; }
        [StringLength(maximumLength: 2, ErrorMessage = "名称不能超过2位长度")]
        public string second_kind_id { get;set; }  

        public string second_kind_name { get;set; }
        [StringLength(maximumLength: 2, ErrorMessage = "名称不能超过2位长度")]
        public string third_kind_id { get;set; }  

        public string third_kind_name { get;set; }  

        public string third_kind_sale_id { get;set; }  

        public string third_kind_is_retail { get;set; } 
    }
}
